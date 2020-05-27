using MyPhotosApi.Api;
using MyPhotosApi.Api.DTOs;
using MyPhotosApi.Api.DTOs.RequestDtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GUI_Proiect2
{
    public partial class Form1 : Form
    {
        private readonly MyPhotosServiceClient _myPhotosServiceClient;
        private CreateFileDto _createMediaFileDto;
        private ModifyFileDto _modifyFileDto;

        public IDictionary<int, PropertyTypeDto> ComboBoxPropertyTypeDtos { get; set; }
        private IList<FileDto> _filteredFiles;
        public Form1()
        {
            InitializeComponent();
            _myPhotosServiceClient = new MyPhotosServiceClient();
            ComboBoxPropertyTypeDtos = new Dictionary<int, PropertyTypeDto>();
            _createMediaFileDto = new CreateFileDto();

            InitializeGuiElements();
        }
        private void InitializeGuiElements()
        {
            _filteredFiles = _myPhotosServiceClient.GetAll();
            AddItemsToFilesListView();

            var propertyTypes = _myPhotosServiceClient.GetAllPropertyTypesWithValues();
            TypeForFilterComboBox.Items.AddRange(propertyTypes.Cast<object>().ToArray());
            

            var propertiesTypes = _myPhotosServiceClient.GetAllPropertiesTypes();

            foreach (var propertyType in propertiesTypes)
            {
                int id = PropertyTypeComboBox.Items.Add(propertyType.Name);
                ComboBoxPropertyTypeDtos.Add(id, propertyType);
            }
        }
        private string GetOpenFileDialogFilter()
        {
            string filter = "";
            foreach (var ext in SupportedMediaFileExtensions.photos)
            {
                filter += ext.Key + "|*" + ext.Value + "|";
            }
            foreach (var ext in SupportedMediaFileExtensions.videos)
            {
                filter += ext.Key + "|*" + ext.Value + "|";
            }
            return filter.Substring(0, filter.Length - 1);
        }
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = "C:\\Users\\mihaela\\source\\repos\\MyPhotos\\AspNetCore_Interface\\wwwroot\\photos";
            openFileDialog.Title = "Add new Media file";
            openFileDialog.Filter = GetOpenFileDialogFilter();
        
        
            if (openFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                EnableButton(UploadPhotoButton);
                DisableButton(ModifyButton);
                DisableButton(DeletePhotoButton);
        
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                _createMediaFileDto = new CreateFileDto()
                {
                    Path = openFileDialog.FileName
                };
            }
        }
        private void AddPropertyButton_Click(object sender, EventArgs e)
        {
            var propertyTypeDto = ComboBoxPropertyTypeDtos[PropertyTypeComboBox.SelectedIndex];
        
            if (_createMediaFileDto.Properties.ContainsKey(propertyTypeDto.Id) == false)
                _createMediaFileDto.Properties.Add(propertyTypeDto.Id, new List<string>());
        
            _createMediaFileDto.Properties[propertyTypeDto.Id].Add(AddPropertyValueTextBox.Text);
        
            var item = new ListViewItem(propertyTypeDto.Name);
            item.Tag = propertyTypeDto.Id;
        
        
            item.SubItems.Add(AddPropertyValueTextBox.Text);
            item.SubItems[1].Tag = "new";
            PropertiesListView.Items.Add(item);
        }


        private void UploadPhotoButton_Click(object sender, EventArgs e)
        {
            _myPhotosServiceClient.LoadFile(_createMediaFileDto);

            TypeForFilterComboBox.Items.Clear();
            var propertyTypes = _myPhotosServiceClient.GetAllPropertyTypesWithValues();
            TypeForFilterComboBox.Items.AddRange(propertyTypes.Cast<object>().ToArray());
        }



        private void AddItemsToFilesListView()
        {

            var imageList = new ImageList();
            imageList.ImageSize = new Size(60, 55);

            foreach (var file in _filteredFiles)
            {
                imageList.Images.Add(file.Path, Image.FromFile(file.Path));

            }

            FilesListView.SmallImageList = imageList;

            foreach (var file in _filteredFiles)
            {
                var item = new ListViewItem(file.Name, file.Path);
                item.Tag = file.Id;

                item.SubItems.Add(file.Path);
                item.SubItems[1].Tag = file.Id;

                FilesListView.Items.Add(item);
            }
        }
        private void FilterButton_Click(object sender, EventArgs e)
        {
            FilesListView.Items.Clear();
            if (TypeForFilterComboBox.SelectedItem == null || ValueForFilterComboBox.SelectedItem == null)
            {
                return;
            }

            FilterFilesDto dto = new FilterFilesDto()
            {
                PropertyTypeId = ((PropertyTypeValuesDto)TypeForFilterComboBox.SelectedItem).Id,
                PropertyValue = ValueForFilterComboBox.SelectedItem.ToString()
            };

            _filteredFiles = _myPhotosServiceClient.GetFilteredMediaFiles(dto);
            AddItemsToFilesListView();
        }

        private void TypeForFilterComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ValueForFilterComboBox.Items.Clear();
            PropertyTypeValuesDto selectedItem = (PropertyTypeValuesDto)TypeForFilterComboBox.SelectedItem;
            ValueForFilterComboBox.Items.AddRange(selectedItem.Values.Cast<object>().ToArray());
        }

        private void DisableButton(Button button)
        {
            button.Visible = false;
            button.Enabled = false;
        }

        private void EnableButton(Button button)
        {
            button.Visible = true;
            button.Enabled = true;
        }
        private void FilesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButton(ModifyButton);
            EnableButton(DeletePhotoButton);
            DisableButton(UploadPhotoButton);
            PropertiesListView.Items.Clear();

            if (FilesListView.SelectedItems.Count != 0)
            {
                var selectedItem = FilesListView.SelectedItems[0];

                _modifyFileDto = new ModifyFileDto();
                _modifyFileDto.FileId = Int32.Parse(selectedItem.Tag.ToString());

                var filepath = selectedItem.SubItems[1].Text;
                pictureBox.Image = Image.FromFile(filepath);
                var fileDto = _filteredFiles.FirstOrDefault(file => file.Id == Int32.Parse(selectedItem.Tag.ToString()));

                if (fileDto != default(FileDto))
                {
                    foreach (var fileDtoProperty in fileDto.Properties)
                    {
                        var item = new ListViewItem(fileDtoProperty.Type);
                        item.Tag = fileDtoProperty.Id;
                        item.SubItems.Add(fileDtoProperty.Value);
                        item.SubItems[1].Tag = "old";
                        PropertiesListView.Items.Add(item);
                    }
                }
            }
        }

        private async void AddPropertyTypeButton_Click(object sender, EventArgs e)
        {
            await _myPhotosServiceClient.AddPropertyTypeAsync(AddPropertyTypeTextBox.Text);
            RefreshFilterComboBox();
            RefreshPropertyTypeComboBox();

        }

        private void RefreshFilterComboBox()
        {
            TypeForFilterComboBox.Items.Clear();
            var propertyTypes = _myPhotosServiceClient.GetAllPropertyTypesWithValues();
            TypeForFilterComboBox.Items.AddRange(propertyTypes.Cast<object>().ToArray());
        }

        private void RefreshPropertyTypeComboBox()
        {
            PropertyTypeComboBox.Items.Clear();
            ComboBoxPropertyTypeDtos.Clear();

            var propertiesTypes = _myPhotosServiceClient.GetAllPropertiesTypes();

            foreach (var propertyType in propertiesTypes)
            {
                int id = PropertyTypeComboBox.Items.Add(propertyType.Name);
                ComboBoxPropertyTypeDtos.Add(id, propertyType);
            }
        }

        private void DeletePropertiesButton_Click(object sender, EventArgs e)
        {
            if (PropertiesListView.SelectedItems.Count != 0)
            {
                var selectedItem = PropertiesListView.SelectedItems[0];

                PropertiesListView.Items.RemoveAt(selectedItem.Index);
                if (selectedItem.SubItems[1].Tag.ToString() == "old")
                {
                    _modifyFileDto.DeletedPropertiesInfo.Add(Int32.Parse(selectedItem.Tag.ToString()), selectedItem.SubItems[1].Text);
                }

            }
        }

        private async void ModifyButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem propertyItem in PropertiesListView.Items)
            {
                if (propertyItem.SubItems[1].Tag.ToString() == "new")
                {
                    var propertyTypeId = Int32.Parse(propertyItem.Tag.ToString());
                    _modifyFileDto.AddedPropertiesInfo.Add(propertyTypeId, propertyItem.SubItems[1].Text);
                }
            }

            await _myPhotosServiceClient.ModifyMediaFileAsync(_modifyFileDto);

            RefreshFilterComboBox();
        }

        private void ViewAllButton_Click(object sender, EventArgs e)
        {
            FilesListView.Items.Clear();
            _filteredFiles = _myPhotosServiceClient.GetAll();
            AddItemsToFilesListView();
        }

        private void DeletePhotoButton_Click(object sender, EventArgs e)
        {
            _myPhotosServiceClient.Delete(_modifyFileDto.FileId);
            var selectedIndex = FilesListView.SelectedItems[0].Index;
            FilesListView.Items.RemoveAt(selectedIndex);
        }
        private void PropertyTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

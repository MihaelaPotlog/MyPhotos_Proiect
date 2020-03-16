using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MyPhotosApi.Api;
using MyPhotosApi.Api.Constants;
using MyPhotosApi.Api.DTOs;
using MyPhotosApi.Api.DTOs.RequestDtos;

namespace MyPhotosGUI
{
    public partial class Form1 : Form
    {
        public MyPhotosApi.Api.Interfaces.MyPhotosApi MyPhotosApi { get; set; }
        private CreateFileDto _createMediaFileDto;
        private ModifyFileDto _modifyFileDto;
        private int _mode;


        public IDictionary<int, PropertyTypeDto> ComboBoxPropertyTypeDtos { get; set; }
        private IList<FileDto> _filteredFiles;
        public Form1()
        {
            InitializeComponent();
            MyPhotosApi = new MyPhotosApi.Api.Interfaces.MyPhotosApi();
            ComboBoxPropertyTypeDtos = new Dictionary<int, PropertyTypeDto>();

            _createMediaFileDto = new CreateFileDto();
            FilesListView.Activation = ItemActivation.OneClick;
            FilesListView.FullRowSelect = true;

            _filteredFiles = MyPhotosApi.MediaFileService.GetAll();
            AddItemsToFilesListView();
            var propertyTypes = MyPhotosApi.PropertyTypeService.GetAllPropertyTypesWithValues();

            TypeForFilterComboBox.Items.AddRange(propertyTypes.Cast<object>().ToArray());


            var propertiesTypes = MyPhotosApi.PropertyTypeService.GetAllPropertiesTypes();

            PropertyTypeComboBox.Items.Clear();
            PropertiesListView.Items.Clear();
            ComboBoxPropertyTypeDtos.Clear();
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
            openFileDialog.InitialDirectory = "C:\\Users\\mihaela\\Desktop\\movie photos";
            openFileDialog.Title = "Add new Media file";
            openFileDialog.Filter = GetOpenFileDialogFilter();

            _mode = Mode.Upload;


            if (openFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                EnableButton(UploadPhotoButton);
                DisableButton(ModifyButton);
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
            MyPhotosApi.MediaFileService.LoadFile(_createMediaFileDto);
        }



        private void AddItemsToFilesListView()
        {
            FilesListView.Items.Clear();
            var imageList = new ImageList();
            imageList.ImageSize = new Size(60,55);

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

            _filteredFiles = MyPhotosApi.MediaFileService.GetFilteredMediaFiles(dto);
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

        private void AddPropertyTypeButton_Click(object sender, EventArgs e)
        {
            MyPhotosApi.PropertyTypeService.AddPropertyType(AddPropertyTypeTextBox.Text);

        }

        private void DeletePropertiesButton_Click(object sender, EventArgs e)
        {
            if (PropertiesListView.SelectedItems.Count != 0)
            {
                var selectedItem = PropertiesListView.SelectedItems[0];
                PropertyTypeLabel.Text = selectedItem.SubItems[1].Tag.ToString();


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
                    ;

                    var propertyTypeId = Int32.Parse(propertyItem.Tag.ToString());
                    _modifyFileDto.AddedPropertiesInfo.Add(propertyTypeId, propertyItem.SubItems[1].Text);
                    PropertyTypeLabel.Text = propertyItem.Tag.ToString() + propertyItem.SubItems[1].Text;
                }

            }

            await MyPhotosApi.MediaFileService.ModifyMediaFile(_modifyFileDto);
        }

        private void ViewAllButton_Click(object sender, EventArgs e)
        {
            _filteredFiles = MyPhotosApi.MediaFileService.GetAll();
            AddItemsToFilesListView();
        }
    }
}



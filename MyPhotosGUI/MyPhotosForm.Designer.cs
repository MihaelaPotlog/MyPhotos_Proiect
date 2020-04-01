namespace MyPhotosGUI
{
    partial class MyPhotosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.TypeForFilterComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FilesListView = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PathColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FilterButton = new System.Windows.Forms.Button();
            this.PropertyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.PropertyTypeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddPropertyButton = new System.Windows.Forms.Button();
            this.UploadPhotoButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.AddPropertyValueTextBox = new System.Windows.Forms.TextBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.ValueForFilterComboBox = new System.Windows.Forms.ComboBox();
            this.PropertiesListView = new System.Windows.Forms.ListView();
            this.TypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeletePropertiesButton = new System.Windows.Forms.Button();
            this.AddPropertyTypeButton = new System.Windows.Forms.Button();
            this.AddPropertyTypeLabel = new System.Windows.Forms.Label();
            this.AddPropertyTypeTextBox = new System.Windows.Forms.TextBox();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ViewAllButton = new System.Windows.Forms.Button();
            this.DeletePhotoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox.Location = new System.Drawing.Point(782, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(653, 399);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // TypeForFilterComboBox
            // 
            this.TypeForFilterComboBox.FormattingEnabled = true;
            this.TypeForFilterComboBox.Location = new System.Drawing.Point(153, 148);
            this.TypeForFilterComboBox.Name = "TypeForFilterComboBox";
            this.TypeForFilterComboBox.Size = new System.Drawing.Size(200, 24);
            this.TypeForFilterComboBox.TabIndex = 1;
            this.TypeForFilterComboBox.SelectionChangeCommitted += new System.EventHandler(this.TypeForFilterComboBox_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Value:";
            // 
            // FilesListView
            // 
            this.FilesListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.FilesListView.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.FilesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.PathColumn});
            this.FilesListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.FilesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilesListView.FullRowSelect = true;
            this.FilesListView.HideSelection = false;
            this.FilesListView.Location = new System.Drawing.Point(12, 317);
            this.FilesListView.Name = "FilesListView";
            this.FilesListView.Size = new System.Drawing.Size(723, 407);
            this.FilesListView.TabIndex = 5;
            this.FilesListView.UseCompatibleStateImageBehavior = false;
            this.FilesListView.View = System.Windows.Forms.View.Details;
            this.FilesListView.SelectedIndexChanged += new System.EventHandler(this.FilesListView_SelectedIndexChanged);
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 144;
            // 
            // PathColumn
            // 
            this.PathColumn.Text = "Path";
            this.PathColumn.Width = 400;
            // 
            // FilterButton
            // 
            this.FilterButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.FilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FilterButton.Location = new System.Drawing.Point(187, 258);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(166, 51);
            this.FilterButton.TabIndex = 6;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = false;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // PropertyTypeComboBox
            // 
            this.PropertyTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropertyTypeComboBox.FormattingEnabled = true;
            this.PropertyTypeComboBox.Location = new System.Drawing.Point(947, 456);
            this.PropertyTypeComboBox.Name = "PropertyTypeComboBox";
            this.PropertyTypeComboBox.Size = new System.Drawing.Size(220, 30);
            this.PropertyTypeComboBox.TabIndex = 8;
            // 
            // PropertyTypeLabel
            // 
            this.PropertyTypeLabel.AutoSize = true;
            this.PropertyTypeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.PropertyTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropertyTypeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PropertyTypeLabel.Location = new System.Drawing.Point(788, 454);
            this.PropertyTypeLabel.Name = "PropertyTypeLabel";
            this.PropertyTypeLabel.Size = new System.Drawing.Size(68, 29);
            this.PropertyTypeLabel.TabIndex = 9;
            this.PropertyTypeLabel.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(790, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Value";
            // 
            // AddPropertyButton
            // 
            this.AddPropertyButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddPropertyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPropertyButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddPropertyButton.Location = new System.Drawing.Point(1219, 502);
            this.AddPropertyButton.Name = "AddPropertyButton";
            this.AddPropertyButton.Size = new System.Drawing.Size(132, 43);
            this.AddPropertyButton.TabIndex = 12;
            this.AddPropertyButton.Text = "Add ";
            this.AddPropertyButton.UseVisualStyleBackColor = false;
            this.AddPropertyButton.Click += new System.EventHandler(this.AddPropertyButton_Click);
            // 
            // UploadPhotoButton
            // 
            this.UploadPhotoButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.UploadPhotoButton.Enabled = false;
            this.UploadPhotoButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadPhotoButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UploadPhotoButton.Location = new System.Drawing.Point(1219, 807);
            this.UploadPhotoButton.Name = "UploadPhotoButton";
            this.UploadPhotoButton.Size = new System.Drawing.Size(216, 46);
            this.UploadPhotoButton.TabIndex = 13;
            this.UploadPhotoButton.Text = "Upload Photo";
            this.UploadPhotoButton.UseVisualStyleBackColor = false;
            this.UploadPhotoButton.Visible = false;
            this.UploadPhotoButton.Click += new System.EventHandler(this.UploadPhotoButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.OpenFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFileButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.OpenFileButton.Location = new System.Drawing.Point(530, 12);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(187, 50);
            this.OpenFileButton.TabIndex = 14;
            this.OpenFileButton.Text = "Upload File";
            this.OpenFileButton.UseVisualStyleBackColor = false;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // AddPropertyValueTextBox
            // 
            this.AddPropertyValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPropertyValueTextBox.Location = new System.Drawing.Point(947, 513);
            this.AddPropertyValueTextBox.Name = "AddPropertyValueTextBox";
            this.AddPropertyValueTextBox.Size = new System.Drawing.Size(220, 28);
            this.AddPropertyValueTextBox.TabIndex = 15;
            // 
            // ValueForFilterComboBox
            // 
            this.ValueForFilterComboBox.FormattingEnabled = true;
            this.ValueForFilterComboBox.Location = new System.Drawing.Point(153, 211);
            this.ValueForFilterComboBox.Name = "ValueForFilterComboBox";
            this.ValueForFilterComboBox.Size = new System.Drawing.Size(200, 24);
            this.ValueForFilterComboBox.TabIndex = 18;
            // 
            // PropertiesListView
            // 
            this.PropertiesListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.PropertiesListView.BackColor = System.Drawing.SystemColors.Info;
            this.PropertiesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TypeColumn,
            this.ValueColumn});
            this.PropertiesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropertiesListView.FullRowSelect = true;
            this.PropertiesListView.HideSelection = false;
            this.PropertiesListView.Location = new System.Drawing.Point(785, 565);
            this.PropertiesListView.Name = "PropertiesListView";
            this.PropertiesListView.Size = new System.Drawing.Size(653, 222);
            this.PropertiesListView.TabIndex = 19;
            this.PropertiesListView.UseCompatibleStateImageBehavior = false;
            this.PropertiesListView.View = System.Windows.Forms.View.Details;
            // 
            // TypeColumn
            // 
            this.TypeColumn.Text = "Property Type";
            this.TypeColumn.Width = 145;
            // 
            // ValueColumn
            // 
            this.ValueColumn.Text = "Value";
            this.ValueColumn.Width = 500;
            // 
            // DeletePropertiesButton
            // 
            this.DeletePropertiesButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.DeletePropertiesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePropertiesButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeletePropertiesButton.Location = new System.Drawing.Point(782, 807);
            this.DeletePropertiesButton.Name = "DeletePropertiesButton";
            this.DeletePropertiesButton.Size = new System.Drawing.Size(254, 46);
            this.DeletePropertiesButton.TabIndex = 20;
            this.DeletePropertiesButton.Text = "Delete Selected Property";
            this.DeletePropertiesButton.UseVisualStyleBackColor = false;
            this.DeletePropertiesButton.Click += new System.EventHandler(this.DeletePropertiesButton_Click);
            // 
            // AddPropertyTypeButton
            // 
            this.AddPropertyTypeButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddPropertyTypeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPropertyTypeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddPropertyTypeButton.Location = new System.Drawing.Point(214, 831);
            this.AddPropertyTypeButton.Name = "AddPropertyTypeButton";
            this.AddPropertyTypeButton.Size = new System.Drawing.Size(161, 39);
            this.AddPropertyTypeButton.TabIndex = 21;
            this.AddPropertyTypeButton.Text = "Add Property Type";
            this.AddPropertyTypeButton.UseVisualStyleBackColor = false;
            this.AddPropertyTypeButton.Click += new System.EventHandler(this.AddPropertyTypeButton_Click);
            // 
            // AddPropertyTypeLabel
            // 
            this.AddPropertyTypeLabel.AutoSize = true;
            this.AddPropertyTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPropertyTypeLabel.Location = new System.Drawing.Point(12, 807);
            this.AddPropertyTypeLabel.Name = "AddPropertyTypeLabel";
            this.AddPropertyTypeLabel.Size = new System.Drawing.Size(168, 24);
            this.AddPropertyTypeLabel.TabIndex = 22;
            this.AddPropertyTypeLabel.Text = "Add Property Type";
            // 
            // AddPropertyTypeTextBox
            // 
            this.AddPropertyTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPropertyTypeTextBox.Location = new System.Drawing.Point(17, 835);
            this.AddPropertyTypeTextBox.Name = "AddPropertyTypeTextBox";
            this.AddPropertyTypeTextBox.Size = new System.Drawing.Size(147, 34);
            this.AddPropertyTypeTextBox.TabIndex = 23;
            // 
            // ModifyButton
            // 
            this.ModifyButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ModifyButton.Enabled = false;
            this.ModifyButton.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ModifyButton.Location = new System.Drawing.Point(1219, 859);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(216, 45);
            this.ModifyButton.TabIndex = 24;
            this.ModifyButton.Text = "Modify Photo";
            this.ModifyButton.UseVisualStyleBackColor = false;
            this.ModifyButton.Visible = false;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(782, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(788, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 29);
            this.label5.TabIndex = 26;
            this.label5.Text = "Add properties";
            // 
            // ViewAllButton
            // 
            this.ViewAllButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ViewAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAllButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewAllButton.Location = new System.Drawing.Point(569, 261);
            this.ViewAllButton.Name = "ViewAllButton";
            this.ViewAllButton.Size = new System.Drawing.Size(166, 50);
            this.ViewAllButton.TabIndex = 27;
            this.ViewAllButton.Text = "View all";
            this.ViewAllButton.UseVisualStyleBackColor = false;
            this.ViewAllButton.Click += new System.EventHandler(this.ViewAllButton_Click);
            // 
            // DeletePhotoButton
            // 
            this.DeletePhotoButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeletePhotoButton.Enabled = false;
            this.DeletePhotoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePhotoButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.DeletePhotoButton.Location = new System.Drawing.Point(1219, 925);
            this.DeletePhotoButton.Name = "DeletePhotoButton";
            this.DeletePhotoButton.Size = new System.Drawing.Size(216, 47);
            this.DeletePhotoButton.TabIndex = 28;
            this.DeletePhotoButton.Text = "Delete Photo";
            this.DeletePhotoButton.UseVisualStyleBackColor = false;
            this.DeletePhotoButton.Visible = false;
            this.DeletePhotoButton.Click += new System.EventHandler(this.DeletePhotoButton_Click);
            // 
            // MyPhotosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 1053);
            this.Controls.Add(this.DeletePhotoButton);
            this.Controls.Add(this.ViewAllButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.AddPropertyTypeTextBox);
            this.Controls.Add(this.AddPropertyTypeLabel);
            this.Controls.Add(this.AddPropertyTypeButton);
            this.Controls.Add(this.DeletePropertiesButton);
            this.Controls.Add(this.PropertiesListView);
            this.Controls.Add(this.ValueForFilterComboBox);
            this.Controls.Add(this.AddPropertyValueTextBox);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.UploadPhotoButton);
            this.Controls.Add(this.AddPropertyButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PropertyTypeLabel);
            this.Controls.Add(this.PropertyTypeComboBox);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.FilesListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TypeForFilterComboBox);
            this.Controls.Add(this.pictureBox);
            this.Location = new System.Drawing.Point(0, 10);
            this.Name = "MyPhotosForm";
            this.Text = "MyPhotosForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox TypeForFilterComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView FilesListView;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.ComboBox PropertyTypeComboBox;
        private System.Windows.Forms.Label PropertyTypeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddPropertyButton;
        private System.Windows.Forms.Button UploadPhotoButton;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox AddPropertyValueTextBox;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.ComboBox ValueForFilterComboBox;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader PathColumn;
        private System.Windows.Forms.ListView PropertiesListView;
        private System.Windows.Forms.ColumnHeader TypeColumn;
        private System.Windows.Forms.ColumnHeader ValueColumn;
        private System.Windows.Forms.Button DeletePropertiesButton;
        private System.Windows.Forms.Button AddPropertyTypeButton;
        private System.Windows.Forms.Label AddPropertyTypeLabel;
        private System.Windows.Forms.TextBox AddPropertyTypeTextBox;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ViewAllButton;
        private System.Windows.Forms.Button DeletePhotoButton;
    }
}


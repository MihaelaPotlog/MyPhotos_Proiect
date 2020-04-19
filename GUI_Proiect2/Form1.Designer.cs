namespace GUI_Proiect2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TypeForFilterComboBox = new System.Windows.Forms.ComboBox();
            this.ValueForFilterComboBox = new System.Windows.Forms.ComboBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.ViewAllButton = new System.Windows.Forms.Button();
            this.FilesListView = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PathColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddPropertyTypeLabel = new System.Windows.Forms.Label();
            this.AddPropertyTypeTextBox = new System.Windows.Forms.TextBox();
            this.AddPropertyTypeButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PropertyTypeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PropertyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.AddPropertyValueTextBox = new System.Windows.Forms.TextBox();
            this.AddPropertyButton = new System.Windows.Forms.Button();
            this.PropertiesListView = new System.Windows.Forms.ListView();
            this.TypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeletePropertiesButton = new System.Windows.Forms.Button();
            this.UploadPhotoButton = new System.Windows.Forms.Button();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.DeletePhotoButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenFileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(670, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(656, 393);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Value";
            // 
            // TypeForFilterComboBox
            // 
            this.TypeForFilterComboBox.FormattingEnabled = true;
            this.TypeForFilterComboBox.Location = new System.Drawing.Point(423, 72);
            this.TypeForFilterComboBox.Name = "TypeForFilterComboBox";
            this.TypeForFilterComboBox.Size = new System.Drawing.Size(175, 24);
            this.TypeForFilterComboBox.TabIndex = 3;
            this.TypeForFilterComboBox.SelectionChangeCommitted += new System.EventHandler(this.TypeForFilterComboBox_SelectionChangeCommitted);
            // 
            // ValueForFilterComboBox
            // 
            this.ValueForFilterComboBox.FormattingEnabled = true;
            this.ValueForFilterComboBox.Location = new System.Drawing.Point(429, 156);
            this.ValueForFilterComboBox.Name = "ValueForFilterComboBox";
            this.ValueForFilterComboBox.Size = new System.Drawing.Size(169, 24);
            this.ValueForFilterComboBox.TabIndex = 4;
            // 
            // FilterButton
            // 
            this.FilterButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterButton.Location = new System.Drawing.Point(267, 247);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(168, 56);
            this.FilterButton.TabIndex = 5;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = false;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // ViewAllButton
            // 
            this.ViewAllButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ViewAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAllButton.Location = new System.Drawing.Point(482, 247);
            this.ViewAllButton.Name = "ViewAllButton";
            this.ViewAllButton.Size = new System.Drawing.Size(145, 56);
            this.ViewAllButton.TabIndex = 6;
            this.ViewAllButton.Text = "View all";
            this.ViewAllButton.UseVisualStyleBackColor = false;
            this.ViewAllButton.Click += new System.EventHandler(this.ViewAllButton_Click);
            // 
            // FilesListView
            // 
            this.FilesListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.FilesListView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FilesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.PathColumn});
            this.FilesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilesListView.FullRowSelect = true;
            this.FilesListView.HideSelection = false;
            this.FilesListView.Location = new System.Drawing.Point(12, 326);
            this.FilesListView.Name = "FilesListView";
            this.FilesListView.Size = new System.Drawing.Size(640, 407);
            this.FilesListView.TabIndex = 7;
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
            // AddPropertyTypeLabel
            // 
            this.AddPropertyTypeLabel.AutoSize = true;
            this.AddPropertyTypeLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddPropertyTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPropertyTypeLabel.Location = new System.Drawing.Point(12, 831);
            this.AddPropertyTypeLabel.Name = "AddPropertyTypeLabel";
            this.AddPropertyTypeLabel.Size = new System.Drawing.Size(176, 25);
            this.AddPropertyTypeLabel.TabIndex = 8;
            this.AddPropertyTypeLabel.Text = "Add Property Type";
            // 
            // AddPropertyTypeTextBox
            // 
            this.AddPropertyTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPropertyTypeTextBox.Location = new System.Drawing.Point(17, 892);
            this.AddPropertyTypeTextBox.Name = "AddPropertyTypeTextBox";
            this.AddPropertyTypeTextBox.Size = new System.Drawing.Size(163, 28);
            this.AddPropertyTypeTextBox.TabIndex = 9;
            // 
            // AddPropertyTypeButton
            // 
            this.AddPropertyTypeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddPropertyTypeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPropertyTypeButton.Location = new System.Drawing.Point(238, 881);
            this.AddPropertyTypeButton.Name = "AddPropertyTypeButton";
            this.AddPropertyTypeButton.Size = new System.Drawing.Size(157, 39);
            this.AddPropertyTypeButton.TabIndex = 10;
            this.AddPropertyTypeButton.Text = "Add Property";
            this.AddPropertyTypeButton.UseVisualStyleBackColor = false;
            this.AddPropertyTypeButton.Click += new System.EventHandler(this.AddPropertyTypeButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(689, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Add Properties";
            // 
            // PropertyTypeLabel
            // 
            this.PropertyTypeLabel.AutoSize = true;
            this.PropertyTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropertyTypeLabel.Location = new System.Drawing.Point(689, 471);
            this.PropertyTypeLabel.Name = "PropertyTypeLabel";
            this.PropertyTypeLabel.Size = new System.Drawing.Size(68, 29);
            this.PropertyTypeLabel.TabIndex = 12;
            this.PropertyTypeLabel.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(700, 536);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Value";
            // 
            // PropertyTypeComboBox
            // 
            this.PropertyTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropertyTypeComboBox.FormattingEnabled = true;
            this.PropertyTypeComboBox.Location = new System.Drawing.Point(874, 475);
            this.PropertyTypeComboBox.Name = "PropertyTypeComboBox";
            this.PropertyTypeComboBox.Size = new System.Drawing.Size(179, 28);
            this.PropertyTypeComboBox.TabIndex = 14;
            this.PropertyTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.PropertyTypeComboBox_SelectedIndexChanged);
            // 
            // AddPropertyValueTextBox
            // 
            this.AddPropertyValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPropertyValueTextBox.Location = new System.Drawing.Point(874, 535);
            this.AddPropertyValueTextBox.Name = "AddPropertyValueTextBox";
            this.AddPropertyValueTextBox.Size = new System.Drawing.Size(179, 30);
            this.AddPropertyValueTextBox.TabIndex = 15;
            // 
            // AddPropertyButton
            // 
            this.AddPropertyButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddPropertyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPropertyButton.Location = new System.Drawing.Point(1126, 517);
            this.AddPropertyButton.Name = "AddPropertyButton";
            this.AddPropertyButton.Size = new System.Drawing.Size(134, 48);
            this.AddPropertyButton.TabIndex = 16;
            this.AddPropertyButton.Text = "Add";
            this.AddPropertyButton.UseVisualStyleBackColor = false;
            this.AddPropertyButton.Click += new System.EventHandler(this.AddPropertyButton_Click);
            // 
            // PropertiesListView
            // 
            this.PropertiesListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.PropertiesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TypeColumn,
            this.ValueColumn});
            this.PropertiesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropertiesListView.FullRowSelect = true;
            this.PropertiesListView.HideSelection = false;
            this.PropertiesListView.Location = new System.Drawing.Point(673, 589);
            this.PropertiesListView.Name = "PropertiesListView";
            this.PropertiesListView.Size = new System.Drawing.Size(653, 222);
            this.PropertiesListView.TabIndex = 17;
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
            this.DeletePropertiesButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DeletePropertiesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePropertiesButton.Location = new System.Drawing.Point(673, 861);
            this.DeletePropertiesButton.Name = "DeletePropertiesButton";
            this.DeletePropertiesButton.Size = new System.Drawing.Size(250, 59);
            this.DeletePropertiesButton.TabIndex = 18;
            this.DeletePropertiesButton.Text = "Delete Selected Property";
            this.DeletePropertiesButton.UseVisualStyleBackColor = false;
            this.DeletePropertiesButton.Click += new System.EventHandler(this.DeletePropertiesButton_Click);
            // 
            // UploadPhotoButton
            // 
            this.UploadPhotoButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.UploadPhotoButton.Enabled = false;
            this.UploadPhotoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadPhotoButton.Location = new System.Drawing.Point(1088, 831);
            this.UploadPhotoButton.Name = "UploadPhotoButton";
            this.UploadPhotoButton.Size = new System.Drawing.Size(226, 56);
            this.UploadPhotoButton.TabIndex = 19;
            this.UploadPhotoButton.Text = "Upload Photo";
            this.UploadPhotoButton.UseVisualStyleBackColor = false;
            this.UploadPhotoButton.Visible = false;
            this.UploadPhotoButton.Click += new System.EventHandler(this.UploadPhotoButton_Click);
            // 
            // ModifyButton
            // 
            this.ModifyButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ModifyButton.Enabled = false;
            this.ModifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyButton.Location = new System.Drawing.Point(1088, 893);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(226, 56);
            this.ModifyButton.TabIndex = 20;
            this.ModifyButton.Text = "Modify Photo";
            this.ModifyButton.UseVisualStyleBackColor = false;
            this.ModifyButton.Visible = false;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // DeletePhotoButton
            // 
            this.DeletePhotoButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.DeletePhotoButton.Enabled = false;
            this.DeletePhotoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePhotoButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeletePhotoButton.Location = new System.Drawing.Point(1088, 955);
            this.DeletePhotoButton.Name = "DeletePhotoButton";
            this.DeletePhotoButton.Size = new System.Drawing.Size(226, 53);
            this.DeletePhotoButton.TabIndex = 21;
            this.DeletePhotoButton.Text = "Delete Photo";
            this.DeletePhotoButton.UseVisualStyleBackColor = false;
            this.DeletePhotoButton.Visible = false;
            this.DeletePhotoButton.Click += new System.EventHandler(this.DeletePhotoButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.OpenFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFileButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OpenFileButton.Location = new System.Drawing.Point(433, 12);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(194, 45);
            this.OpenFileButton.TabIndex = 22;
            this.OpenFileButton.Text = "Upload Photo";
            this.OpenFileButton.UseVisualStyleBackColor = false;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 1053);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.DeletePhotoButton);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.UploadPhotoButton);
            this.Controls.Add(this.DeletePropertiesButton);
            this.Controls.Add(this.PropertiesListView);
            this.Controls.Add(this.AddPropertyButton);
            this.Controls.Add(this.AddPropertyValueTextBox);
            this.Controls.Add(this.PropertyTypeComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PropertyTypeLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddPropertyTypeButton);
            this.Controls.Add(this.AddPropertyTypeTextBox);
            this.Controls.Add(this.AddPropertyTypeLabel);
            this.Controls.Add(this.FilesListView);
            this.Controls.Add(this.ViewAllButton);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.ValueForFilterComboBox);
            this.Controls.Add(this.TypeForFilterComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.AddPropertyButton_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TypeForFilterComboBox;
        private System.Windows.Forms.ComboBox ValueForFilterComboBox;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button ViewAllButton;
        private System.Windows.Forms.ListView FilesListView;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader PathColumn;
        private System.Windows.Forms.Label AddPropertyTypeLabel;
        private System.Windows.Forms.TextBox AddPropertyTypeTextBox;
        private System.Windows.Forms.Button AddPropertyTypeButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PropertyTypeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PropertyTypeComboBox;
        private System.Windows.Forms.TextBox AddPropertyValueTextBox;
        private System.Windows.Forms.Button AddPropertyButton;
        private System.Windows.Forms.ListView PropertiesListView;
        private System.Windows.Forms.ColumnHeader TypeColumn;
        private System.Windows.Forms.ColumnHeader ValueColumn;
        private System.Windows.Forms.Button DeletePropertiesButton;
        private System.Windows.Forms.Button UploadPhotoButton;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.Button DeletePhotoButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button OpenFileButton;
    }
}


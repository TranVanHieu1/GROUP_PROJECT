﻿namespace BookStore_HoangNT
{
    partial class BookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            lblFormTitle = new Label();
            gbBookInfo = new GroupBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            cboCategory = new ComboBox();
            dtpReleasedDate = new DateTimePicker();
            txtAuthor = new TextBox();
            txtDescription = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            lblCategory = new Label();
            lblAuthor = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblReleasedDate = new Label();
            lblDesc = new Label();
            lblName = new Label();
            lblId = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            gbBookInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.BackColor = Color.Transparent;
            lblFormTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormTitle.ForeColor = Color.Navy;
            lblFormTitle.Location = new Point(53, 18);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(205, 46);
            lblFormTitle.TabIndex = 21;
            lblFormTitle.Text = "Add a Book";
            // 
            // gbBookInfo
            // 
            gbBookInfo.BackColor = Color.Transparent;
            gbBookInfo.Controls.Add(txtPrice);
            gbBookInfo.Controls.Add(txtQuantity);
            gbBookInfo.Controls.Add(cboCategory);
            gbBookInfo.Controls.Add(dtpReleasedDate);
            gbBookInfo.Controls.Add(txtAuthor);
            gbBookInfo.Controls.Add(txtDescription);
            gbBookInfo.Controls.Add(txtName);
            gbBookInfo.Controls.Add(txtId);
            gbBookInfo.Controls.Add(lblCategory);
            gbBookInfo.Controls.Add(lblAuthor);
            gbBookInfo.Controls.Add(lblPrice);
            gbBookInfo.Controls.Add(lblQuantity);
            gbBookInfo.Controls.Add(lblReleasedDate);
            gbBookInfo.Controls.Add(lblDesc);
            gbBookInfo.Controls.Add(lblName);
            gbBookInfo.Controls.Add(lblId);
            gbBookInfo.ForeColor = Color.Navy;
            gbBookInfo.Location = new Point(53, 101);
            gbBookInfo.Name = "gbBookInfo";
            gbBookInfo.Size = new Size(514, 445);
            gbBookInfo.TabIndex = 22;
            gbBookInfo.TabStop = false;
            gbBookInfo.Text = " Book Info ";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(359, 299);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(131, 299);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 4;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(131, 393);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(353, 28);
            cboCategory.TabIndex = 7;
            // 
            // dtpReleasedDate
            // 
            dtpReleasedDate.CustomFormat = "dd/MM/yyyy";
            dtpReleasedDate.Format = DateTimePickerFormat.Custom;
            dtpReleasedDate.Location = new Point(131, 251);
            dtpReleasedDate.Name = "dtpReleasedDate";
            dtpReleasedDate.Size = new Size(152, 27);
            dtpReleasedDate.TabIndex = 3;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(131, 343);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(353, 27);
            txtAuthor.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(131, 128);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(353, 102);
            txtDescription.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(131, 86);
            txtName.Name = "txtName";
            txtName.Size = new Size(353, 27);
            txtName.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ControlLightLight;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Location = new Point(131, 43);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 0;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.FromArgb(255, 128, 0);
            lblCategory.Location = new Point(17, 396);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(69, 20);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.BackColor = Color.FromArgb(255, 128, 0);
            lblAuthor.Location = new Point(17, 346);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(54, 20);
            lblAuthor.TabIndex = 6;
            lblAuthor.Text = "Author";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(288, 298);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.FromArgb(255, 128, 0);
            lblQuantity.ForeColor = Color.Navy;
            lblQuantity.Location = new Point(17, 302);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(65, 20);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity";
            // 
            // lblReleasedDate
            // 
            lblReleasedDate.AutoSize = true;
            lblReleasedDate.BackColor = Color.FromArgb(255, 128, 0);
            lblReleasedDate.ForeColor = Color.Navy;
            lblReleasedDate.Location = new Point(17, 256);
            lblReleasedDate.Name = "lblReleasedDate";
            lblReleasedDate.Size = new Size(105, 20);
            lblReleasedDate.TabIndex = 3;
            lblReleasedDate.Text = "Released Date";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.BackColor = Color.FromArgb(255, 128, 0);
            lblDesc.ForeColor = Color.Navy;
            lblDesc.Location = new Point(17, 131);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(85, 20);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "Description";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.FromArgb(255, 128, 0);
            lblName.ForeColor = Color.Navy;
            lblName.Location = new Point(17, 89);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = Color.FromArgb(255, 128, 0);
            lblId.ForeColor = Color.Navy;
            lblId.Location = new Point(17, 45);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 0, 0);
            btnCancel.ForeColor = Color.Yellow;
            btnCancel.Location = new Point(473, 565);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 192, 0);
            btnSave.ForeColor = Color.Gold;
            btnSave.Location = new Point(362, 565);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(633, 618);
            Controls.Add(lblFormTitle);
            Controls.Add(gbBookInfo);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add | Update Book";
            Load += BookForm_Load;
            gbBookInfo.ResumeLayout(false);
            gbBookInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormTitle;
        private GroupBox gbBookInfo;
        private ComboBox cboCategory;
        private DateTimePicker dtpReleasedDate;
        private TextBox txtAuthor;
        private TextBox txtDescription;
        private TextBox txtName;
        private TextBox txtId;
        private Label lblCategory;
        private Label lblAuthor;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblReleasedDate;
        private Label lblDesc;
        private Label lblName;
        private Label lblId;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtPrice;
        private TextBox txtQuantity;
    }
}
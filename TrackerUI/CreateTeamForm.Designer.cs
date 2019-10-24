namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.teamNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectTeamMemberComboBox = new System.Windows.Forms.ComboBox();
            this.grpAddNewMemeber = new System.Windows.Forms.GroupBox();
            this.createMemeberButton = new System.Windows.Forms.Button();
            this.cellphoneTextBox = new System.Windows.Forms.TextBox();
            this.lblCellphone = new System.Windows.Forms.Label();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.removeSelectedTeamButton = new System.Windows.Forms.Button();
            this.addMembersButton = new System.Windows.Forms.Button();
            this.grpAddNewMemeber.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(70, 23);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(148, 32);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Create Team";
            // 
            // teamNameTextBox
            // 
            this.teamNameTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameTextBox.Location = new System.Drawing.Point(77, 72);
            this.teamNameTextBox.Name = "teamNameTextBox";
            this.teamNameTextBox.Size = new System.Drawing.Size(345, 38);
            this.teamNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(71, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Team Member";
            // 
            // selectTeamMemberComboBox
            // 
            this.selectTeamMemberComboBox.FormattingEnabled = true;
            this.selectTeamMemberComboBox.Location = new System.Drawing.Point(77, 213);
            this.selectTeamMemberComboBox.Name = "selectTeamMemberComboBox";
            this.selectTeamMemberComboBox.Size = new System.Drawing.Size(345, 39);
            this.selectTeamMemberComboBox.TabIndex = 1;
            // 
            // grpAddNewMemeber
            // 
            this.grpAddNewMemeber.Controls.Add(this.createMemeberButton);
            this.grpAddNewMemeber.Controls.Add(this.cellphoneTextBox);
            this.grpAddNewMemeber.Controls.Add(this.lblCellphone);
            this.grpAddNewMemeber.Controls.Add(this.emailAddressTextBox);
            this.grpAddNewMemeber.Controls.Add(this.label3);
            this.grpAddNewMemeber.Controls.Add(this.lastNameTextBox);
            this.grpAddNewMemeber.Controls.Add(this.label2);
            this.grpAddNewMemeber.Controls.Add(this.firstNameTextBox);
            this.grpAddNewMemeber.Controls.Add(this.lblFirstName);
            this.grpAddNewMemeber.Location = new System.Drawing.Point(66, 325);
            this.grpAddNewMemeber.Name = "grpAddNewMemeber";
            this.grpAddNewMemeber.Size = new System.Drawing.Size(356, 300);
            this.grpAddNewMemeber.TabIndex = 11;
            this.grpAddNewMemeber.TabStop = false;
            this.grpAddNewMemeber.Text = "Add New Member";
            // 
            // createMemeberButton
            // 
            this.createMemeberButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.createMemeberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createMemeberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createMemeberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemeberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.createMemeberButton.Location = new System.Drawing.Point(64, 239);
            this.createMemeberButton.Name = "createMemeberButton";
            this.createMemeberButton.Size = new System.Drawing.Size(209, 41);
            this.createMemeberButton.TabIndex = 15;
            this.createMemeberButton.Text = "Create Member";
            this.createMemeberButton.UseVisualStyleBackColor = true;
            this.createMemeberButton.Click += new System.EventHandler(this.createMemeberButton_Click);
            // 
            // cellphoneTextBox
            // 
            this.cellphoneTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellphoneTextBox.Location = new System.Drawing.Point(158, 175);
            this.cellphoneTextBox.Name = "cellphoneTextBox";
            this.cellphoneTextBox.Size = new System.Drawing.Size(192, 38);
            this.cellphoneTextBox.TabIndex = 3;
            // 
            // lblCellphone
            // 
            this.lblCellphone.AutoSize = true;
            this.lblCellphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.lblCellphone.Location = new System.Drawing.Point(8, 175);
            this.lblCellphone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCellphone.Name = "lblCellphone";
            this.lblCellphone.Size = new System.Drawing.Size(124, 32);
            this.lblCellphone.TabIndex = 14;
            this.lblCellphone.Text = "Cellphone";
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressTextBox.Location = new System.Drawing.Point(158, 131);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(192, 38);
            this.emailAddressTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(8, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(158, 87);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(192, 38);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(8, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Last Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(158, 43);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(192, 38);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.lblFirstName.Location = new System.Drawing.Point(8, 43);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(130, 32);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name";
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.createTeamButton.Location = new System.Drawing.Point(389, 631);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(268, 61);
            this.createTeamButton.TabIndex = 16;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            this.createTeamButton.Click += new System.EventHandler(this.createTeamButton_Click);
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 31;
            this.teamMembersListBox.Location = new System.Drawing.Point(537, 53);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(247, 469);
            this.teamMembersListBox.TabIndex = 2;
            // 
            // removeSelectedTeamButton
            // 
            this.removeSelectedTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.removeSelectedTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.removeSelectedTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.removeSelectedTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.removeSelectedTeamButton.Location = new System.Drawing.Point(812, 259);
            this.removeSelectedTeamButton.Name = "removeSelectedTeamButton";
            this.removeSelectedTeamButton.Size = new System.Drawing.Size(187, 86);
            this.removeSelectedTeamButton.TabIndex = 25;
            this.removeSelectedTeamButton.Text = "Remove Selected";
            this.removeSelectedTeamButton.UseVisualStyleBackColor = true;
            this.removeSelectedTeamButton.Click += new System.EventHandler(this.removeSelectedTeamButton_Click);
            // 
            // addMembersButton
            // 
            this.addMembersButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addMembersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addMembersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addMembersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMembersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.addMembersButton.Location = new System.Drawing.Point(130, 259);
            this.addMembersButton.Name = "addMembersButton";
            this.addMembersButton.Size = new System.Drawing.Size(209, 48);
            this.addMembersButton.TabIndex = 26;
            this.addMembersButton.Text = "Add Members";
            this.addMembersButton.UseVisualStyleBackColor = true;
            this.addMembersButton.Click += new System.EventHandler(this.addMembersButton_Click);
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 872);
            this.Controls.Add(this.addMembersButton);
            this.Controls.Add(this.removeSelectedTeamButton);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.grpAddNewMemeber);
            this.Controls.Add(this.selectTeamMemberComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teamNameTextBox);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateTeamForm";
            this.Text = "CreateTeamForm";
            this.grpAddNewMemeber.ResumeLayout(false);
            this.grpAddNewMemeber.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox teamNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectTeamMemberComboBox;
        private System.Windows.Forms.GroupBox grpAddNewMemeber;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox cellphoneTextBox;
        private System.Windows.Forms.Label lblCellphone;
        private System.Windows.Forms.TextBox emailAddressTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createMemeberButton;
        private System.Windows.Forms.Button createTeamButton;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button removeSelectedTeamButton;
        private System.Windows.Forms.Button addMembersButton;
    }
}
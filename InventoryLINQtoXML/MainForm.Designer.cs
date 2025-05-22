
namespace InventoryLINQtoXML
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInventory = new System.Windows.Forms.Label();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.grbAdd = new System.Windows.Forms.GroupBox();
            this.lblMake = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grbLookup = new System.Windows.Forms.GroupBox();
            this.txtMakeLookup = new System.Windows.Forms.TextBox();
            this.lblMakeLookup = new System.Windows.Forms.Label();
            this.btnLookUp = new System.Windows.Forms.Button();
            this.grbAdd.SuspendLayout();
            this.grbLookup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Location = new System.Drawing.Point(12, 9);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(122, 20);
            this.lblInventory.TabIndex = 0;
            this.lblInventory.Text = "Current Inventory";
            // 
            // txtInventory
            // 
            this.txtInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInventory.Location = new System.Drawing.Point(12, 32);
            this.txtInventory.Multiline = true;
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.ReadOnly = true;
            this.txtInventory.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInventory.Size = new System.Drawing.Size(300, 406);
            this.txtInventory.TabIndex = 1;
            // 
            // grbAdd
            // 
            this.grbAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbAdd.Controls.Add(this.btnAdd);
            this.grbAdd.Controls.Add(this.txtPetName);
            this.grbAdd.Controls.Add(this.lblName);
            this.grbAdd.Controls.Add(this.txtColor);
            this.grbAdd.Controls.Add(this.lblColor);
            this.grbAdd.Controls.Add(this.txtMake);
            this.grbAdd.Controls.Add(this.lblMake);
            this.grbAdd.Location = new System.Drawing.Point(333, 32);
            this.grbAdd.Name = "grbAdd";
            this.grbAdd.Size = new System.Drawing.Size(455, 235);
            this.grbAdd.TabIndex = 2;
            this.grbAdd.TabStop = false;
            this.grbAdd.Text = "Add Inventory Item";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(6, 43);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(45, 20);
            this.lblMake.TabIndex = 0;
            this.lblMake.Text = "Make";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(89, 43);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(360, 27);
            this.txtMake.TabIndex = 1;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(89, 88);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(360, 27);
            this.txtColor.TabIndex = 3;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(6, 88);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(45, 20);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Color";
            // 
            // txtPetName
            // 
            this.txtPetName.Location = new System.Drawing.Point(89, 133);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(360, 27);
            this.txtPetName.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 133);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 20);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Pet Name";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(261, 182);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(188, 29);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // grbLookup
            // 
            this.grbLookup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbLookup.Controls.Add(this.btnLookUp);
            this.grbLookup.Controls.Add(this.txtMakeLookup);
            this.grbLookup.Controls.Add(this.lblMakeLookup);
            this.grbLookup.Location = new System.Drawing.Point(333, 273);
            this.grbLookup.Name = "grbLookup";
            this.grbLookup.Size = new System.Drawing.Size(455, 145);
            this.grbLookup.TabIndex = 3;
            this.grbLookup.TabStop = false;
            this.grbLookup.Text = "Look up Colors for Make";
            // 
            // txtMakeLookup
            // 
            this.txtMakeLookup.Location = new System.Drawing.Point(170, 42);
            this.txtMakeLookup.Name = "txtMakeLookup";
            this.txtMakeLookup.Size = new System.Drawing.Size(279, 27);
            this.txtMakeLookup.TabIndex = 3;
            // 
            // lblMakeLookup
            // 
            this.lblMakeLookup.AutoSize = true;
            this.lblMakeLookup.Location = new System.Drawing.Point(6, 42);
            this.lblMakeLookup.Name = "lblMakeLookup";
            this.lblMakeLookup.Size = new System.Drawing.Size(120, 20);
            this.lblMakeLookup.TabIndex = 2;
            this.lblMakeLookup.Text = "Make to Look up";
            // 
            // btnLookUp
            // 
            this.btnLookUp.Location = new System.Drawing.Point(261, 91);
            this.btnLookUp.Name = "btnLookUp";
            this.btnLookUp.Size = new System.Drawing.Size(188, 29);
            this.btnLookUp.TabIndex = 4;
            this.btnLookUp.Text = "Look up Colors";
            this.btnLookUp.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbLookup);
            this.Controls.Add(this.grbAdd);
            this.Controls.Add(this.txtInventory);
            this.Controls.Add(this.lblInventory);
            this.Name = "MainForm";
            this.Text = "Inventory LINQ to XML";
            this.grbAdd.ResumeLayout(false);
            this.grbAdd.PerformLayout();
            this.grbLookup.ResumeLayout(false);
            this.grbLookup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.GroupBox grbAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPetName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.GroupBox grbLookup;
        private System.Windows.Forms.Button btnLookUp;
        private System.Windows.Forms.TextBox txtMakeLookup;
        private System.Windows.Forms.Label lblMakeLookup;
    }
}


namespace PrintInfoDB_COPY
{
    partial class FormPartners
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
            labelOut = new Label();
            flowLayoutPanelTop = new FlowLayoutPanel();
            buttonPartnerAdd = new Button();
            buttonParnterUpdate = new Button();
            buttonPartnerDelete = new Button();
            panelFill = new Panel();
            dataGridViewTypes = new DataGridView();
            flowLayoutPanelTop.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).BeginInit();
            SuspendLayout();
            // 
            // labelOut
            // 
            labelOut.AutoSize = true;
            labelOut.Dock = DockStyle.Left;
            labelOut.Location = new Point(0, 0);
            labelOut.Margin = new Padding(5, 0, 5, 0);
            labelOut.Name = "labelOut";
            labelOut.Size = new Size(0, 25);
            labelOut.TabIndex = 0;
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.Controls.Add(buttonPartnerAdd);
            flowLayoutPanelTop.Controls.Add(buttonParnterUpdate);
            flowLayoutPanelTop.Controls.Add(buttonPartnerDelete);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(10);
            flowLayoutPanelTop.Size = new Size(1055, 61);
            flowLayoutPanelTop.TabIndex = 1;
            // 
            // buttonPartnerAdd
            // 
            buttonPartnerAdd.Location = new Point(15, 15);
            buttonPartnerAdd.Margin = new Padding(5);
            buttonPartnerAdd.Name = "buttonPartnerAdd";
            buttonPartnerAdd.Size = new Size(150, 35);
            buttonPartnerAdd.TabIndex = 0;
            buttonPartnerAdd.Text = "Добавить";
            buttonPartnerAdd.UseVisualStyleBackColor = true;
            buttonPartnerAdd.Click += buttonPartnerAdd_Click;
            // 
            // buttonParnterUpdate
            // 
            buttonParnterUpdate.Location = new Point(175, 15);
            buttonParnterUpdate.Margin = new Padding(5);
            buttonParnterUpdate.Name = "buttonParnterUpdate";
            buttonParnterUpdate.Size = new Size(150, 35);
            buttonParnterUpdate.TabIndex = 1;
            buttonParnterUpdate.Text = "Редактировать";
            buttonParnterUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonPartnerDelete
            // 
            buttonPartnerDelete.Location = new Point(335, 15);
            buttonPartnerDelete.Margin = new Padding(5);
            buttonPartnerDelete.Name = "buttonPartnerDelete";
            buttonPartnerDelete.Size = new Size(150, 35);
            buttonPartnerDelete.TabIndex = 2;
            buttonPartnerDelete.Text = "Удалить";
            buttonPartnerDelete.UseVisualStyleBackColor = true;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewTypes);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 61);
            panelFill.Margin = new Padding(5);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(1055, 593);
            panelFill.TabIndex = 2;
            // 
            // dataGridViewTypes
            // 
            dataGridViewTypes.BackgroundColor = Color.White;
            dataGridViewTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTypes.Dock = DockStyle.Fill;
            dataGridViewTypes.Location = new Point(10, 10);
            dataGridViewTypes.Name = "dataGridViewTypes";
            dataGridViewTypes.Size = new Size(1035, 573);
            dataGridViewTypes.TabIndex = 0;
            // 
            // FormPartners
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1055, 654);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelTop);
            Controls.Add(labelOut);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormPartners";
            Text = "Тип Партнера";
            Load += Form1_Load;
            flowLayoutPanelTop.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOut;
        private FlowLayoutPanel flowLayoutPanelTop;
        private Panel panelFill;
        private Button buttonPartnerAdd;
        private Button buttonParnterUpdate;
        private Button buttonPartnerDelete;
        private DataGridView dataGridViewTypes;
    }
}

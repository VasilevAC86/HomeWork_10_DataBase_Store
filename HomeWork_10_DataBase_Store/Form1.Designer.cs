namespace HomeWork_10_DataBase_Store
{
    partial class MainForm
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
            this.btnConnectDB = new System.Windows.Forms.Button();
            this.tBOutput = new System.Windows.Forms.TextBox();
            this.cLB_Query = new System.Windows.Forms.CheckedListBox();
            this.lb_DB = new System.Windows.Forms.Label();
            this.lb_Query = new System.Windows.Forms.Label();
            this.lb_Result = new System.Windows.Forms.Label();
            this.tB_Result = new System.Windows.Forms.TextBox();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnectDB
            // 
            this.btnConnectDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConnectDB.Location = new System.Drawing.Point(694, 45);
            this.btnConnectDB.Name = "btnConnectDB";
            this.btnConnectDB.Size = new System.Drawing.Size(250, 30);
            this.btnConnectDB.TabIndex = 0;
            this.btnConnectDB.Text = "Подключиться к базе";
            this.btnConnectDB.UseVisualStyleBackColor = true;
            this.btnConnectDB.Click += new System.EventHandler(this.btnConnectDB_Click);
            // 
            // tBOutput
            // 
            this.tBOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBOutput.Location = new System.Drawing.Point(27, 45);
            this.tBOutput.Multiline = true;
            this.tBOutput.Name = "tBOutput";
            this.tBOutput.Size = new System.Drawing.Size(600, 400);
            this.tBOutput.TabIndex = 1;
            // 
            // cLB_Query
            // 
            this.cLB_Query.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cLB_Query.FormattingEnabled = true;
            this.cLB_Query.Items.AddRange(new object[] {
            "1. Сколько покупателей купили часы в 2023 году?",
            "2. Каков средний возраст, купивших кулон 14 февраля?",
            "3. Какой \"средний чек\" покупок 31 декабря?"});
            this.cLB_Query.Location = new System.Drawing.Point(27, 494);
            this.cLB_Query.Name = "cLB_Query";
            this.cLB_Query.Size = new System.Drawing.Size(600, 94);
            this.cLB_Query.TabIndex = 2;
            // 
            // lb_DB
            // 
            this.lb_DB.AutoSize = true;
            this.lb_DB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_DB.Location = new System.Drawing.Point(24, 22);
            this.lb_DB.Name = "lb_DB";
            this.lb_DB.Size = new System.Drawing.Size(108, 17);
            this.lb_DB.TabIndex = 3;
            this.lb_DB.Text = "База данных:";
            // 
            // lb_Query
            // 
            this.lb_Query.AutoSize = true;
            this.lb_Query.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Query.Location = new System.Drawing.Point(24, 474);
            this.lb_Query.Name = "lb_Query";
            this.lb_Query.Size = new System.Drawing.Size(78, 17);
            this.lb_Query.TabIndex = 4;
            this.lb_Query.Text = "Запросы:";
            // 
            // lb_Result
            // 
            this.lb_Result.AutoSize = true;
            this.lb_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Result.Location = new System.Drawing.Point(673, 474);
            this.lb_Result.Name = "lb_Result";
            this.lb_Result.Size = new System.Drawing.Size(156, 17);
            this.lb_Result.TabIndex = 5;
            this.lb_Result.Text = "Результат запроса:";
            // 
            // tB_Result
            // 
            this.tB_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_Result.Location = new System.Drawing.Point(676, 495);
            this.tB_Result.Multiline = true;
            this.tB_Result.Name = "tB_Result";
            this.tB_Result.Size = new System.Drawing.Size(250, 94);
            this.tB_Result.TabIndex = 6;
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Disconnect.Location = new System.Drawing.Point(694, 95);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(250, 30);
            this.btn_Disconnect.TabIndex = 7;
            this.btn_Disconnect.Text = "Отключиться от базы";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Save.Location = new System.Drawing.Point(694, 145);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(250, 30);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Сохранить изменения в базе";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Disconnect);
            this.Controls.Add(this.tB_Result);
            this.Controls.Add(this.lb_Result);
            this.Controls.Add(this.lb_Query);
            this.Controls.Add(this.lb_DB);
            this.Controls.Add(this.cLB_Query);
            this.Controls.Add(this.tBOutput);
            this.Controls.Add(this.btnConnectDB);
            this.Name = "MainForm";
            this.Text = "База данных магазина";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnectDB;
        private System.Windows.Forms.TextBox tBOutput;
        private System.Windows.Forms.CheckedListBox cLB_Query;
        private System.Windows.Forms.Label lb_DB;
        private System.Windows.Forms.Label lb_Query;
        private System.Windows.Forms.Label lb_Result;
        private System.Windows.Forms.TextBox tB_Result;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.Button btn_Save;
    }
}


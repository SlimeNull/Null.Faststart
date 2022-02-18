﻿namespace Null.Faststart.WinForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_apply_all = new System.Windows.Forms.Button();
            this.btn_config = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.lv_links = new System.Windows.Forms.DataGridView();
            this.bdr_links = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lv_links)).BeginInit();
            this.bdr_links.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            resources.ApplyResources(this.btn_ok, "btn_ok");
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_apply_all
            // 
            resources.ApplyResources(this.btn_apply_all, "btn_apply_all");
            this.btn_apply_all.Name = "btn_apply_all";
            this.btn_apply_all.UseVisualStyleBackColor = true;
            this.btn_apply_all.Click += new System.EventHandler(this.btn_apply_all_Click);
            // 
            // btn_config
            // 
            resources.ApplyResources(this.btn_config, "btn_config");
            this.btn_config.Name = "btn_config";
            this.btn_config.UseVisualStyleBackColor = true;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
            // 
            // btn_cancel
            // 
            resources.ApplyResources(this.btn_cancel, "btn_cancel");
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_add
            // 
            resources.ApplyResources(this.btn_add, "btn_add");
            this.btn_add.Name = "btn_add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            resources.ApplyResources(this.btn_edit, "btn_edit");
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_remove
            // 
            resources.ApplyResources(this.btn_remove, "btn_remove");
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_about
            // 
            resources.ApplyResources(this.btn_about, "btn_about");
            this.btn_about.Name = "btn_about";
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // lv_links
            // 
            this.lv_links.AllowDrop = true;
            this.lv_links.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lv_links.BackgroundColor = System.Drawing.SystemColors.Control;
            this.lv_links.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_links.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.lv_links, "lv_links");
            this.lv_links.MultiSelect = false;
            this.lv_links.Name = "lv_links";
            this.lv_links.RowHeadersVisible = false;
            this.lv_links.RowTemplate.Height = 25;
            this.lv_links.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.lv_links.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lv_links.ShowEditingIcon = false;
            this.lv_links.DragDrop += new System.Windows.Forms.DragEventHandler(this.lv_links_DragDrop);
            this.lv_links.DragEnter += new System.Windows.Forms.DragEventHandler(this.lv_links_DragEnter);
            this.lv_links.DoubleClick += new System.EventHandler(this.lv_links_DoubleClick);
            // 
            // bdr_links
            // 
            resources.ApplyResources(this.bdr_links, "bdr_links");
            this.bdr_links.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bdr_links.Controls.Add(this.lv_links);
            this.bdr_links.Name = "bdr_links";
            // 
            // MainForm
            // 
            this.AcceptButton = this.btn_ok;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.Controls.Add(this.bdr_links);
            this.Controls.Add(this.btn_config);
            this.Controls.Add(this.btn_apply_all);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lv_links)).EndInit();
            this.bdr_links.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_apply_all;
        private System.Windows.Forms.Button btn_config;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.DataGridView lv_links;
        private System.Windows.Forms.Panel bdr_links;
        private System.Windows.Forms.ToolTip toolTip;
    }
}


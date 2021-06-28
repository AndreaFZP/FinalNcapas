
namespace Biblioteca.Presentacion
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.pswrdTxt = new System.Windows.Forms.Label();
            this.pswrdInput = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(351, 47);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(92, 17);
            this.title.TabIndex = 0;
            this.title.Text = "Iniciar Sesión";
            // 
            // emailTxt
            // 
            this.emailTxt.AutoSize = true;
            this.emailTxt.Location = new System.Drawing.Point(101, 114);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(42, 17);
            this.emailTxt.TabIndex = 1;
            this.emailTxt.Text = "Email";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(104, 134);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(248, 22);
            this.emailInput.TabIndex = 2;
            // 
            // pswrdTxt
            // 
            this.pswrdTxt.AutoSize = true;
            this.pswrdTxt.Location = new System.Drawing.Point(101, 211);
            this.pswrdTxt.Name = "pswrdTxt";
            this.pswrdTxt.Size = new System.Drawing.Size(69, 17);
            this.pswrdTxt.TabIndex = 3;
            this.pswrdTxt.Text = "Password";
            // 
            // pswrdInput
            // 
            this.pswrdInput.Location = new System.Drawing.Point(104, 231);
            this.pswrdInput.Name = "pswrdInput";
            this.pswrdInput.Size = new System.Drawing.Size(248, 22);
            this.pswrdInput.TabIndex = 4;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(354, 308);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.pswrdInput);
            this.Controls.Add(this.pswrdTxt);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.title);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label emailTxt;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label pswrdTxt;
        private System.Windows.Forms.TextBox pswrdInput;
        private System.Windows.Forms.Button loginBtn;
    }
}


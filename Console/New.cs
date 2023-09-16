System.Windows.Forms.Form form = new();
form.Text = "New window";
Label label = new();
label.Text = "This is your first form!";
label.Size = new System.Drawing.Size(100,100);
label.Location = new System.Drawing.Point(form.Size.Width / 2, form.Size.Height / 2);
form.Controls.Add(label);
//form.Show();
Application.Run(form);
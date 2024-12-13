using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace Project16_MailRegister
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		Db16ProjectEntities context = new Db16ProjectEntities();
		private void btnRegister_Click(object sender, EventArgs e)
		{
			Random random = new Random();
			int confirmCode=random.Next(100000,1000000);

			TblUser user = new TblUser();

			user.Email = txtEmail.Text;
			user.Name = txtName.Text;
			user.Password = txtPassword.Text;
			user.Surname = txtSurname.Text;
			user.IsConfirm = false;
			user.ConfirmCode = confirmCode.ToString();

			context.TblUser.Add(user);
			context.SaveChanges();

			#region Mail Kodları
			MimeMessage mimeMessage = new MimeMessage();

			MailboxAddress mailboxAddressFrom = new MailboxAddress("AdminRegister","mail adresi"); //Mailin kimden gittiği
			mimeMessage.From.Add(mailboxAddressFrom); //Gönderen kişinin adresi

			MailboxAddress mailboxAddressTo = new MailboxAddress("User", txtEmail.Text);//Kime gidecek
			mimeMessage.To.Add(mailboxAddressTo); // Alıcı kişinin adresi

			var bodyBuilder = new BodyBuilder();
			bodyBuilder.TextBody = "Email Adresinizin Konfirmasyon Kodu: " + confirmCode; //mesaj içeriğini yazacak
			mimeMessage.Body=bodyBuilder.ToMessageBody();

			mimeMessage.Subject = "Email Konfirmasyon Kodu"; //Mesaj konu başlığı

			SmtpClient smtpClient = new SmtpClient();
			smtpClient.Connect("smtp.gmail.com", 587, false);
			smtpClient.Authenticate("mail yazılacak", "key yazılacak"); //gmailden uygulama kodu alınması gerekiyor
			smtpClient.Send(mimeMessage);
			smtpClient.Disconnect(true);

			MessageBox.Show("Mail adresinize doğrulama kodu gönderilmiştir");
			
			FrmMailConfirm frm = new FrmMailConfirm();
			frm.email= txtEmail.Text;	//buradaki mail adresini diğer forma taşıyoruz
			frm.Show();

			#endregion
		}
	}
}

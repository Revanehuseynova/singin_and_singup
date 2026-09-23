using System.Collections;

namespace MYproject_singin_singup
{
    public partial class Form1 : Form
    {
        // Foydalanuvchi ma'lumotlarini vaqtincha saqlash uchun ro'yxatlar
        ArrayList usernames = new ArrayList();
        ArrayList passwords = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        // Form yuklanganda parollarni yashirish
        private void Form1_Load(object sender, EventArgs e)
        {
            if (txtLoginPass != null) txtLoginPass.UseSystemPasswordChar = true;
            if (txtRegPass != null) txtRegPass.UseSystemPasswordChar = true;
        }

        // SIGN UP (Ro'yxatdan o'tish) tugmasi
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string user = txtRegUser.Text.Trim();
            string pass = txtRegPass.Text;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Xana boş olmaz", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (usernames.Contains(user))
            {
                MessageBox.Show("Bu istifadəçi adı artıq mövcuddur", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            usernames.Add(user);
            passwords.Add(pass);

            MessageBox.Show("Qeydiyyat uğurla tamamlandı!", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtRegUser.Clear();
            txtRegPass.Clear();
            chkRegShow.Checked = false;
        }

        // SIGN IN (Tizimga kirish) tugmasi
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string user = txtLoginUser.Text.Trim();
            string pass = txtLoginPass.Text;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Xana boş olmaz", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = usernames.IndexOf(user);

            if (index >= 0 && passwords[index].ToString() == pass)
            {
                MessageBox.Show("Sistemə daxil oldunuz!", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLoginUser.Clear();
                txtLoginPass.Clear();
                chkLoginShow.Checked = false;
            }
            else
            {
                MessageBox.Show("İstifadəçi adı və ya şifrə yanlışdır", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sign In uchun parolni ko'rsatish/yashirish
        private void chkLoginShow_CheckedChanged(object sender, EventArgs e)
        {
            txtLoginPass.UseSystemPasswordChar = !chkLoginShow.Checked;
        }

        // Sign Up uchun parolni ko'rsatish/yashirish
        private void chkRegShow_CheckedChanged(object sender, EventArgs e)
        {
            txtRegPass.UseSystemPasswordChar = !chkRegShow.Checked;
        }

        // Dizayn faylida adashib bosilgan joylar uchun bo'sh hodisalar (Xatolikni yo'qotish uchun)
        private void txtLoginUser_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtLoginPass_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
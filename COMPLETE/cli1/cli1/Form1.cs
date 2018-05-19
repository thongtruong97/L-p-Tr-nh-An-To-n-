using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Security.Cryptography;

namespace cli1
{
    public partial class Form1 : Form
    {
        aes aes256 = new aes();
        int duration = 0;
        public string dt = DateTime.Now.ToString();
        public byte[] APublicKey;
        public byte[] AKey;
        public byte[] bobPublicKey;
        private byte[] bobKey;
        byte[] nhanText, nhanPublicKey, nhanLength;
        Socket client01;
        Socket client02;
        IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9050);
        EndPoint ep;
        //private RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thr = new Thread(new ThreadStart(NhanDL));
            thr.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //    client01 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //    client01.Bind(ipep);
            //    client01.Listen(4);
            //    //client02 = client01.Accept();
            //    client01.BeginAccept(new AsyncCallback(CallAccept), client01);
            //}
            //private void CallAccept(IAsyncResult i)
            //{
            //    client02 = ((Socket)i.AsyncState).EndAccept(i);
            //    thr = new Thread(new ThreadStart(nhanDuLieu));
            //    thr.Start();

            genKey_Click(sender, e);
        }
        void NhanDL()
        {
            try
            {
                if (txtIP.Text == "" || txtRemote.Text == "" || txtLocal.Text == "")
                {
                    MessageBox.Show("nhap du lieu day du");
                }
                else
                {
                    UdpClient nhandulieu = new UdpClient(int.Parse(txtLocal.Text));
                    IPEndPoint ipe = new IPEndPoint(IPAddress.Any, 0);
                    while (true)
                    {
                        byte[] data = new byte[1024 * 24];
                        data = nhandulieu.Receive(ref ipe);
                        string s = Encoding.UTF8.GetString(data);
                        if (s.Trim().ToUpper().Equals("QUIT"))
                            break;
                        string[] arrString = s.Split(';');
                        string encryptedText = arrString[0];
                        string dt = arrString[1];
                        string md5EncryptedText = arrString[2];
                        string _a = arrString[3];
                        string paddingValue = arrString[4];
                        string hashEncryptedText = HashMd5(encryptedText);
                        if (md5EncryptedText == hashEncryptedText)
                        {
                            txtNhan.Invoke((MethodInvoker)delegate ()
                            {
                                txtNhan.Text += "\nĐã nhận: " + s;

                            });
                            keyPad.Text = _a;
                            txtPad.Text = encryptedText;
                            string rawText = DecryptedNew(encryptedText, dt);
                            txtDPAD.Text = rawText.Substring(0, rawText.Length - int.Parse(paddingValue));
                        }

                        else
                        {
                            txtNhan.Invoke((MethodInvoker)delegate ()
                            {
                                txtNhan.Text += "\nĐã nhận: Noi dung da bi thay doi.";

                            });
                        }
                       
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //void NhanDL2()
        //{
        //    try
        //    {
        //        if (txtIP.Text == "" || txtRemote.Text == "" || txtLocal.Text == "")
        //        {
        //            MessageBox.Show("nhap du lieu day du");
        //        }
        //        else
        //        {
        //            UdpClient nhandulieu = new UdpClient(int.Parse(txtLocal.Text));
        //            IPEndPoint ipe = new IPEndPoint(IPAddress.Any, 0);
        //            while (true)
        //            {
        //                byte[] data = new byte[1024];
        //                data = nhandulieu.Receive(ref ipe);
        //                string s = Encoding.UTF8.GetString(data);
        //                if (s.Trim().ToUpper().Equals("QUIT"))
        //                    break;

        //                txtNhan.Invoke((MethodInvoker)delegate ()
        //                {
        //                    txtNhan.Text += "\nĐã nhận: " + s;
        //                    txtencry.Text = s;
        //                });



        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            UdpClient guidulieu = new UdpClient();
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(txtIP.Text), int.Parse(txtRemote.Text));

            byte[] data = new byte[1024*24];
            data = Encoding.UTF8.GetBytes(final.Text);
            //data = Encoding.UTF8.GetBytes(txtencry.Text);
            guidulieu.Send(data, data.Length, ipe);


            txtNhan.Invoke((MethodInvoker)delegate ()
            {
                txtNhan.Text += "\nĐã gửi:" + txtNhap.Text;
                //txtEPAD.Text = s;
            });
            txtNhap.Clear();
            KhoiTaoTimer();
        }


        private void txtNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UdpClient guidulieu = new UdpClient();
                IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(txtIP.Text), int.Parse(txtRemote.Text));

                byte[] data = new byte[1024];
                data = Encoding.UTF8.GetBytes(txtNhap.Text);
                guidulieu.Send(data, data.Length, ipe);
                txtNhan.Invoke((MethodInvoker)delegate ()
                {
                    txtNhan.Text += "\nĐã gửi:" + txtNhap.Text;
                });
                txtNhap.Clear();
            }
        }

      

        public string Encrypt(string key, string data, string dt)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException("key", "Key must not be empty");
            byte[][] keys = GetHashKeys(key, dt);
            string encData = EncryptStringToBytes_Aes(data, keys[0], keys[1]);
            return encData;
        }
        public string Decrypt(string key, string data, string dt)
        {
            string decData = null;
            byte[][] keys = GetHashKeys(key, dt);
            try
            {
                decData = DecryptStringFromBytes_Aes(data, keys[0], keys[1]);
            }
            catch (CryptographicException) { }
            catch (ArgumentNullException) { }
            return decData;
        }
        private byte[][] GetHashKeys(string key, string dt)
        {
            byte[][] result = new byte[2][];
            Encoding enc = Encoding.UTF8;

            SHA256 sha2 = new SHA256CryptoServiceProvider();

            byte[] rawKey = enc.GetBytes(key);
            byte[] rawIV = enc.GetBytes(dt);

            byte[] hashKey = sha2.ComputeHash(rawKey);
            byte[] hashIV = sha2.ComputeHash(rawIV);

            Array.Resize(ref hashIV, 16);

            result[0] = hashKey;
            result[1] = hashIV;

            return result;
        }
        private static string EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            if (plainText == null || plainText.Length <= 0)
            {
                throw new ArgumentNullException("plainText");
            }
            if (Key == null || Key.Length <= 0)
            {
                throw new ArgumentNullException("Key");
            }
            if (IV == null || IV.Length <= 0)
            {
                throw new ArgumentNullException("IV");
            }

            byte[] encrypted;

            using (AesManaged aes = new AesManaged())
            {
                aes.Key = Key;
                aes.IV = IV;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(encrypted);
        }
        private static string DecryptStringFromBytes_Aes(string cipherTextString, byte[] Key, byte[] IV)
        {
            byte[] cipherText = Convert.FromBase64String(cipherTextString);

            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            string plaintext = null;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt =
                            new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return plaintext;
        }

        public string Encrypted()
        {

            string rawText = txtNhap.Text;
            string key = txtkey.Text;
            string encryptedText = Encrypt(key, rawText, dt);
            return encryptedText;
        }

        public string Decrypted(string TextMaHoa)
        {
            string encryptedText = TextMaHoa;
            string key = txtkey.Text;
            string rawText = Decrypt(key, encryptedText, dt);
            return rawText;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //if (txtNhap.Text == "" || txtkey.Text == "")
            //{
            //    MessageBox.Show("Fulfill both Text and Key boxes in other to run the program!");
            //}
            //dt = DateTime.Now.ToString();
            //string rawText = txtNhap.Text;
            //string key = txtkey.Text;
            //string encryptedText = Encrypt(key, rawText, dt);
            ////string encryptedText = Encrypted();
            //string final = encryptedText + ";" + dt;
            //txtencry.Text = final;
            txtencry.Text = Encrypted();

        }

        private void decry_Click(object sender, EventArgs e)
        {
            //string s = txtencry.Text;
            //string[] arrString = s.Split(';');
            //string encryptedText = arrString[0];
            //string iv = arrString[1];
            //string rawtext = Decrypted(encryptedText, iv);
            //string finalen = rawtext + ";" + dt;
            //txtdecry.Text = finalen;

            txtdecry.Text = Decrypted(txtencry.Text);
        }
        //public key
        private void genKey_Click(object sender, EventArgs e)
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9050);
            IPEndPoint ipc = new IPEndPoint(IPAddress.Any, 0);
            client01 = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            client01.Bind(ipep);
            ep = (EndPoint)(ipc);

            nhanLength = new byte[100];
            int recLength = client01.ReceiveFrom(nhanLength, ref ep);
            int y = BitConverter.ToInt32(nhanLength, 0);

            nhanPublicKey = new byte[y];
            int recPublicKey = client01.ReceiveFrom(nhanPublicKey, ref ep);

            string publicKey02 = Encoding.ASCII.GetString(nhanPublicKey, 0, recPublicKey);
            int count = Encoding.ASCII.GetByteCount(publicKey02);

            txtkey.Text = Convert.ToBase64String(nhanPublicKey, 0, count);
            byte[] secretKey01 = secretKey(nhanPublicKey);
            txtPubA.Text = Convert.ToBase64String(secretKey01);

            byte[] publicKey = generatePublicKey();
            int x = publicKey.Length;
            byte[] length = BitConverter.GetBytes(x);
            client01.SendTo(length, ep);
            client01.SendTo(publicKey, ep);
            client01.SendTo(secretKey01, ep);
            txtPubB.Text = Convert.ToBase64String(publicKey);
            client01.Close();
            EncrytPad.Enabled = true;
            btnEncryptNoise.Enabled = true;
            button2.Enabled = true;
            //rsa = new RSACryptoServiceProvider(1024);
            //txtPubA.Text = Convert.ToBase64String(rsa.ExportCspBlob(false));
            //txtkey.Text = Convert.ToBase64String(rsa.ExportCspBlob(true));

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //UdpClient guidulieu = new UdpClient();
            //IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(txtIP.Text), int.Parse(txtRemote.Text));

            //byte[] data = new byte[1024];
            //data = Encoding.UTF8.GetBytes(txtencry.Text);
            //guidulieu.Send(data, data.Length, ipe);
            //txtNhan.Invoke((MethodInvoker)delegate ()
            //{
            //    txtNhan.Text += "\nĐã gửi:" + txtNhap.Text;
            //});
            //txtNhap.Clear();



        }

        void nhanDuLieu()
        {
            while (true)
            {
                if (client02.Poll(1000000, SelectMode.SelectRead))
                {

                    nhanText = new byte[1024 * 24];
                    client02.BeginReceive(nhanText, 0, nhanText.Length, SocketFlags.None, new AsyncCallback(ReceivedData), client02);
                }
            }
        }
        private void SendData(IAsyncResult iar)
        {
            client02 = (Socket)iar.AsyncState;
            int sent = client02.EndSend(iar);

        }

        private void ReceivedData(IAsyncResult iar)
        {

            {
                client02 = (Socket)iar.AsyncState;
                int recv = client02.EndReceive(iar);
                //Nhận dữ liệu bên Client-02 gửi
                string s = Encoding.ASCII.GetString(nhanText, 0, recv);
                //Tách mảng chuỗi theo dấu ';' : Chuỗi mã hóa, IV, MD5 Chuỗi mã hóa, PKey, Padding của Client-02
                string[] arrstr = s.Split(';');
                string encryptedText = txtEPAD.Text;
                string keypad = keyPad.Text;
                string textpad = txtPad.Text;
                string txtfinal = final.Text;
            }
        }

        //GENKEY diffie
        public byte[] generatePublicKey()
        {
            //alicePublicKey = new byte[1024];
            using (ECDiffieHellmanCng alice = new ECDiffieHellmanCng())
            {

                //byte[] alicePublicKey;
                alice.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
                alice.HashAlgorithm = CngAlgorithm.Sha256;
                APublicKey = alice.PublicKey.ToByteArray();
                byte[] a = APublicKey;
                return a;
            }

        }

        
        public byte[] secretKey(byte[] bobPublicKey)
        {
            //aliceKey = new byte[1024];
            using (ECDiffieHellmanCng alice = new ECDiffieHellmanCng())
            {
               
                CngKey k = CngKey.Import(bobPublicKey, CngKeyBlobFormat.EccPublicBlob);
                AKey = alice.DeriveKeyMaterial(k);
                byte[] a = AKey;
                return a;
            }
            
        }

        public static byte[] EncryptData(string data)
        {
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
            byte[] hashedBytes;
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(data));
            return hashedBytes;
        }
        public static string HashMd5(string data)
        {
            return BitConverter.ToString(EncryptData(data)).Replace("-", "").ToLower();
        }

        public string EncryptedNew(string rawString, string keyText, string iv)
        {
            string rawText = rawString;
            string key = keyText;
            string encryptedText = aes256.Encrypt(rawText, key, dt);
            return encryptedText;
        }

        public string DecryptedNew(string textEncrypted, string Time)
        {
            string encryptedText = textEncrypted;
            string key = keyPad.Text;
            string decryptedText = aes256.Decrypt(textEncrypted, key, Time);
            return decryptedText;
        }

       

        private string randomString32byte(int size)
        {
            StringBuilder sb = new StringBuilder();
            char c;
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                c = Convert.ToChar(Convert.ToInt32(rand.Next(65, 122))); //Limit: chu thuong, chu hoa
                sb.Append(c);
            }
            return sb.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtIP.Text = "127.0.0.1";
            txtLocal.Text = "90";
            txtRemote.Text = "60";
        }

        
      

        private int paddingData()
        {
            string Timestamp = new DateTimeOffset(DateTime.UtcNow).ToUniversalTime().ToString("yyyyMMddHHmmss");
            string MHtimeStamp = HashMd5(Timestamp);
            int soByteCuaChuoi = UTF8Encoding.UTF8.GetByteCount(txtNhap.Text);
            int lengthNeed = 32 - soByteCuaChuoi;
            int i = 0;
            string tmpTime = string.Empty;
            if (soByteCuaChuoi % 16 != 0)
            {
                i = 1;
                int length = soByteCuaChuoi;
                while (length % 16 != 0)
                {
                    tmpTime = MHtimeStamp.Substring(0, i);
                    length = length + 1;
                    i++;
                }
            }
            txtPad.Text = txtNhap.Text + tmpTime;
            return i - 1;
        }
        public static string PhatSinhNgauNhienKyTu02()
        {
            char[] chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&".ToCharArray();
            Random r = new Random();
            int i = r.Next(chars.Length);
            return chars[i].ToString();
        }
        private void EncrytPad_Click(object sender, EventArgs e)
        {
            dt = HashMd5(DateTime.Now.ToString());
            keyPad.Text = randomString32byte(16);
            string _a = keyPad.Text;
            string valuePadding = paddingData().ToString();
            string encryptedText = EncryptedNew(txtPad.Text, keyPad.Text, dt);
        

            string MD5encryptedText = HashMd5(encryptedText);
            txtEPAD.Text = MD5encryptedText;
            string finalText = encryptedText + ";" + dt + ";" + MD5encryptedText + ";" +_a+";"+ valuePadding;
            final.Text = finalText;
        }
        private void btnEncryptNoise_Click(object sender, EventArgs e)
        {
            dt = HashMd5(DateTime.Now.ToString());
            keyPad.Text = randomString32byte(16);
            string _a = keyPad.Text;
            string valuePadding = paddingData().ToString();
            string encryptedText = EncryptedNew(txtPad.Text, keyPad.Text, dt);
            string a = encryptedText;
            Random r = new Random();
            int length = encryptedText.Length;
            int randomPos = r.Next(0, length + 1);
            string stringDauDenRandomPos = a.Substring(0, randomPos);
            string kyTuCuoiCuaText = a.Substring(randomPos);
            string textChanged = stringDauDenRandomPos + PhatSinhNgauNhienKyTu02() + kyTuCuoiCuaText;
            string MD5encryptedText = HashMd5(textChanged);
            txtEPAD.Text = MD5encryptedText;
            string finalText = encryptedText + ";" + dt + ";" + MD5encryptedText + ";" + _a + ";" + valuePadding;
            final.Text = finalText;
        }
        private void DecryptPad_Click(object sender, EventArgs e)
        {
            string s = final.Text;
            string[] arrstr = s.Split(';');
            string encryptedText = arrstr[0];
            string dt = arrstr[1];
            string md5 = arrstr[2];
            string pad = arrstr[4];
            string st = DecryptedNew(encryptedText, dt);
            txtDPAD.Text = st.Substring(0, st.Length - int.Parse(pad));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            duration = duration + 1;
            lbTimer.Text = duration.ToString();
            if (duration == 10)
            {

                timer1.Stop();
                duration = 0;
                MessageBox.Show("Session Time Out!");
                EncrytPad.Enabled = false;
                btnEncryptNoise.Enabled = false;
                button2.Enabled = false;
                txtPubA.Clear();
                txtEPAD.Clear();
            }
        }

        public void KhoiTaoTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
            timer1.Start();
        }

     

        
    }
}

namespace IR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct family
        {
            public string ግዕዝ;
            public string ካብዕ;
            public string ሳልስ;
            public string ሪብዕ;
            public string ሀምስ;
            public string ሳድስ;
            public string ሳብዕ;
            public string ዲቃላ;
        };

        public string word;

        private void buttonሀ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ሀ";
            buttonካብዕ.Text = "ሁ";
            buttonሳልስ.Text = "ሂ";
            buttonሪብዕ.Text = "ሃ";
            buttonሀምስ.Text = "ሄ";
            buttonሳድስ.Text = "ህ";
            buttonሳብዕ.Text = "ሆ";
            buttonዲቃላ.Visible = false;
            familyadd();
        }

        private void buttonለ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ለ";
            buttonካብዕ.Text = "ሉ";
            buttonሳልስ.Text = "ሊ";
            buttonሪብዕ.Text = "ላ";
            buttonሀምስ.Text = "ሌ";
            buttonሳድስ.Text = "ል";
            buttonሳብዕ.Text = "ሎ";
            buttonዲቃላ.Text = "ሏ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonሐ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ሐ";
            buttonካብዕ.Text = "ሑ";
            buttonሳልስ.Text = "ሒ";
            buttonሪብዕ.Text = "ሓ";
            buttonሀምስ.Text = "ሔ";
            buttonሳድስ.Text = "ሕ";
            buttonሳብዕ.Text = "ሖ";
            buttonዲቃላ.Text = "ሗ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonመ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "መ";
            buttonካብዕ.Text = "ሙ";
            buttonሳልስ.Text = "ሚ";
            buttonሪብዕ.Text = "ማ";
            buttonሀምስ.Text = "ሜ";
            buttonሳድስ.Text = "ም";
            buttonሳብዕ.Text = "ሞ";
            buttonዲቃላ.Text = "ሟ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonሠ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ሠ";
            buttonካብዕ.Text = "ሡ";
            buttonሳልስ.Text = "ሢ";
            buttonሪብዕ.Text = "ሣ";
            buttonሀምስ.Text = "ሤ";
            buttonሳድስ.Text = "ሥ";
            buttonሳብዕ.Text = "ሦ";
            buttonዲቃላ.Text = "ሧ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonረ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ረ";
            buttonካብዕ.Text = "ሩ";
            buttonሳልስ.Text = "ሪ";
            buttonሪብዕ.Text = "ራ";
            buttonሀምስ.Text = "ሬ";
            buttonሳድስ.Text = "ር";
            buttonሳብዕ.Text = "ሮ";
            buttonዲቃላ.Text = "ሯ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonሰ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ሰ";
            buttonካብዕ.Text = "ሱ";
            buttonሳልስ.Text = "ሲ";
            buttonሪብዕ.Text = "ሳ";
            buttonሀምስ.Text = "ሴ";
            buttonሳድስ.Text = "ስ";
            buttonሳብዕ.Text = "ሶ";
            buttonዲቃላ.Text = "ሷ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonሸ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ሸ";
            buttonካብዕ.Text = "ሹ";
            buttonሳልስ.Text = "ሺ";
            buttonሪብዕ.Text = "ሻ";
            buttonሀምስ.Text = "ሼ";
            buttonሳድስ.Text = "ሽ";
            buttonሳብዕ.Text = "ሾ";
            buttonዲቃላ.Text = "ሿ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonቀ_Click(object sender, EventArgs e)
        {   
            panel.Visible = true;
            buttonግዕዝ.Text = "ቀ";
            buttonካብዕ.Text = "ቁ";
            buttonሳልስ.Text = "ቂ";
            buttonሪብዕ.Text = "ቃ";
            buttonሀምስ.Text = "ቄ";
            buttonሳድስ.Text = "ቅ";
            buttonሳብዕ.Text = "ቆ";
            buttonዲቃላ.Text = "ቇ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonቐ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ቐ";
            buttonካብዕ.Text = "ቑ";
            buttonሳልስ.Text = "ቒ";
            buttonሪብዕ.Text = "ቓ";
            buttonሀምስ.Text = "ቔ";
            buttonሳድስ.Text = "ቕ";
            buttonሳብዕ.Text = "ቖ";
            buttonዲቃላ.Visible=false;
            familyadd();
        }

        private void buttonበ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "በ";
            buttonካብዕ.Text = "ቡ";
            buttonሳልስ.Text = "ቢ";
            buttonሪብዕ.Text = "ባ";
            buttonሀምስ.Text = "ቤ";
            buttonሳድስ.Text = "ብ";
            buttonሳብዕ.Text = "ቦ";
            buttonዲቃላ.Text = "ቧ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonቨ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ቨ";
            buttonካብዕ.Text = "ቩ";
            buttonሳልስ.Text = "ቪ";
            buttonሪብዕ.Text = "ቫ";
            buttonሀምስ.Text = "ቬ";
            buttonሳድስ.Text = "ቭ";
            buttonሳብዕ.Text = "ቮ";
            buttonዲቃላ.Text = "ቯ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonተ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ተ";
            buttonካብዕ.Text = "ቱ";
            buttonሳልስ.Text = "ቲ";
            buttonሪብዕ.Text = "ታ";
            buttonሀምስ.Text = "ቴ";
            buttonሳድስ.Text = "ት";
            buttonሳብዕ.Text = "ቶ";
            buttonዲቃላ.Text = "ቷ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonቸ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ቸ";
            buttonካብዕ.Text = "ቹ";
            buttonሳልስ.Text = "ቺ";
            buttonሪብዕ.Text = "ቻ";
            buttonሀምስ.Text = "ቼ";
            buttonሳድስ.Text = "ች";
            buttonሳብዕ.Text = "ቾ";
            buttonዲቃላ.Text = "ቿ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonኀ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ኀ";
            buttonካብዕ.Text = "ኁ";
            buttonሳልስ.Text = "ኂ";
            buttonሪብዕ.Text = "ኃ";
            buttonሀምስ.Text = "ኄ";
            buttonሳድስ.Text = "ኅ";
            buttonሳብዕ.Text = "ኆ";
            buttonዲቃላ.Text = "ኇ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonነ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ነ";
            buttonካብዕ.Text = "ኑ";
            buttonሳልስ.Text = "ኒ";
            buttonሪብዕ.Text = "ና";
            buttonሀምስ.Text = "ኔ";
            buttonሳድስ.Text = "ን";
            buttonሳብዕ.Text = "ኖ";
            buttonዲቃላ.Text = "ኗ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonኘ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ኘ";
            buttonካብዕ.Text = "ኙ";
            buttonሳልስ.Text = "ኚ";
            buttonሪብዕ.Text = "ኛ";
            buttonሀምስ.Text = "ኜ";
            buttonሳድስ.Text = "ኝ";
            buttonሳብዕ.Text = "ኞ";
            buttonዲቃላ.Text = "ኟ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonአ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "አ";
            buttonካብዕ.Text = "ኡ";
            buttonሳልስ.Text = "ኢ";
            buttonሪብዕ.Text = "ኣ";
            buttonሀምስ.Text = "ኤ";
            buttonሳድስ.Text = "እ";
            buttonሳብዕ.Text = "ኦ";
            buttonዲቃላ.Text = "ኧ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonከ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ከ";
            buttonካብዕ.Text = "ኩ";
            buttonሳልስ.Text = "ኪ";
            buttonሪብዕ.Text = "ካ";
            buttonሀምስ.Text = "ኬ";
            buttonሳድስ.Text = "ክ";
            buttonሳብዕ.Text = "ኮ";
            buttonዲቃላ.Text = "ኯ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonኸ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ኸ";
            buttonካብዕ.Text = "ኹ";
            buttonሳልስ.Text = "ኺ";
            buttonሪብዕ.Text = "ኻ";
            buttonሀምስ.Text = "ኼ";
            buttonሳድስ.Text = "ኽ";
            buttonሳብዕ.Text = "ኾ";
            buttonዲቃላ.Visible = false;
            familyadd();
        }

        private void buttonወ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ወ";
            buttonካብዕ.Text = "ዉ";
            buttonሳልስ.Text = "ዊ";
            buttonሪብዕ.Text = "ዋ";
            buttonሀምስ.Text = "ዌ";
            buttonሳድስ.Text = "ው";
            buttonሳብዕ.Text = "ዎ";
            buttonዲቃላ.Visible = false;
            familyadd();
        }

        private void buttonዐ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ዐ";
            buttonካብዕ.Text = "ዑ";
            buttonሳልስ.Text = "ዒ";
            buttonሪብዕ.Text = "ዓ";
            buttonሀምስ.Text = "ዔ";
            buttonሳድስ.Text = "ዕ";
            buttonሳብዕ.Text = "ዖ";
            buttonዲቃላ.Visible = false;
            familyadd();
        }

        private void buttonዘ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ዘ";
            buttonካብዕ.Text = "ዙ";
            buttonሳልስ.Text = "ዚ";
            buttonሪብዕ.Text = "ዛ";
            buttonሀምስ.Text = "ዜ";
            buttonሳድስ.Text = "ዝ";
            buttonሳብዕ.Text = "ዞ";
            buttonዲቃላ.Text = "ዟ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonዠ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ዠ";
            buttonካብዕ.Text = "ዡ";
            buttonሳልስ.Text = "ዢ";
            buttonሪብዕ.Text = "ዣ";
            buttonሀምስ.Text = "ዤ";
            buttonሳድስ.Text = "ዥ";
            buttonሳብዕ.Text = "ዦ";
            buttonዲቃላ.Text = "ዧ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonየ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "የ";
            buttonካብዕ.Text = "ዩ";
            buttonሳልስ.Text = "ዪ";
            buttonሪብዕ.Text = "ያ";
            buttonሀምስ.Text = "ዬ";
            buttonሳድስ.Text = "ይ";
            buttonሳብዕ.Text = "ዮ";
            buttonዲቃላ.Text = "ዯ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonደ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ደ";
            buttonካብዕ.Text = "ዱ";
            buttonሳልስ.Text = "ዲ";
            buttonሪብዕ.Text = "ዳ";
            buttonሀምስ.Text = "ዴ";
            buttonሳድስ.Text = "ድ";
            buttonሳብዕ.Text = "ዶ";
            buttonዲቃላ.Text = "ዷ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonዸ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ዸ";
            buttonካብዕ.Text = "ዹ";
            buttonሳልስ.Text = "ዺ";
            buttonሪብዕ.Text = "ዻ";
            buttonሀምስ.Text = "ዼ";
            buttonሳድስ.Text = "ዽ";
            buttonሳብዕ.Text = "ዾ";
            buttonዲቃላ.Text = "ዿ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonጀ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ጀ";
            buttonካብዕ.Text = "ጁ";
            buttonሳልስ.Text = "ጂ";
            buttonሪብዕ.Text = "ጃ";
            buttonሀምስ.Text = "ጄ";
            buttonሳድስ.Text = "ጅ";
            buttonሳብዕ.Text = "ጆ";
            buttonዲቃላ.Text = "ጇ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonገ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ገ";
            buttonካብዕ.Text = "ጉ";
            buttonሳልስ.Text = "ጊ";
            buttonሪብዕ.Text = "ጋ";
            buttonሀምስ.Text = "ጌ";
            buttonሳድስ.Text = "ግ";
            buttonሳብዕ.Text = "ጎ";
            buttonዲቃላ.Text = "ጏ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonጘ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ጘ";
            buttonካብዕ.Text = "ጙ";
            buttonሳልስ.Text = "ጚ";
            buttonሪብዕ.Text = "ጛ";
            buttonሀምስ.Text = "ጜ";
            buttonሳድስ.Text = "ጝ";
            buttonሳብዕ.Text = "ጞ";
            buttonዲቃላ.Text = "ጟ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonጠ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ጠ";
            buttonካብዕ.Text = "ጡ";
            buttonሳልስ.Text = "ጢ";
            buttonሪብዕ.Text = "ጣ";
            buttonሀምስ.Text = "ጤ";
            buttonሳድስ.Text = "ጥ";
            buttonሳብዕ.Text = "ጦ";
            buttonዲቃላ.Text = "ጧ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonጨ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ጨ";
            buttonካብዕ.Text = "ጩ";
            buttonሳልስ.Text = "ጪ";
            buttonሪብዕ.Text = "ጫ";
            buttonሀምስ.Text = "ጬ";
            buttonሳድስ.Text = "ጭ";
            buttonሳብዕ.Text = "ጮ";
            buttonዲቃላ.Text = "ጯ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonጰ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ጰ";
            buttonካብዕ.Text = "ጱ";
            buttonሳልስ.Text = "ጲ";
            buttonሪብዕ.Text = "ጳ";
            buttonሀምስ.Text = "ጴ";
            buttonሳድስ.Text = "ጵ";
            buttonሳብዕ.Text = "ጶ";
            buttonዲቃላ.Text = "ጷ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonጸ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ጸ";
            buttonካብዕ.Text = "ጹ";
            buttonሳልስ.Text = "ጺ";
            buttonሪብዕ.Text = "ጻ";
            buttonሀምስ.Text = "ጼ";
            buttonሳድስ.Text = "ጽ";
            buttonሳብዕ.Text = "ጾ";
            buttonዲቃላ.Text = "ጿ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonፀ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ፀ";
            buttonካብዕ.Text = "ፁ";
            buttonሳልስ.Text = "ፂ";
            buttonሪብዕ.Text = "ፃ";
            buttonሀምስ.Text = "ፄ";
            buttonሳድስ.Text = "ፅ";
            buttonሳብዕ.Text = "ፆ";
            buttonዲቃላ.Text = "ፇ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonፈ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ፈ";
            buttonካብዕ.Text = "ፉ";
            buttonሳልስ.Text = "ፊ";
            buttonሪብዕ.Text = "ፋ";
            buttonሀምስ.Text = "ፌ";
            buttonሳድስ.Text = "ፍ";
            buttonሳብዕ.Text = "ፎ";
            buttonዲቃላ.Text = "ፏ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonፐ_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            buttonግዕዝ.Text = "ፐ";
            buttonካብዕ.Text = "ፑ";
            buttonሳልስ.Text = "ፒ";
            buttonሪብዕ.Text = "ፓ";
            buttonሀምስ.Text = "ፔ";
            buttonሳድስ.Text = "ፕ";
            buttonሳብዕ.Text = "ፖ";
            buttonዲቃላ.Text = "ፗ";
            buttonዲቃላ.Visible = true;
            familyadd();
        }

        private void buttonግዕዝ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonግዕዝ.Text;
            wordadd(buttonግዕዝ.Text);
        }

        private void buttonካብዕ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonካብዕ.Text;
            wordadd(buttonሳድስ.Text + "ኡ");
        }

        private void buttonሳልስ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonሳልስ.Text;
            wordadd(buttonሳልስ.Text);
        }

        private void buttonሪብዕ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonሪብዕ.Text;
            wordadd(buttonሪብዕ.Text);
        }

        private void buttonሀምስ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonሀምስ.Text;
            wordadd(buttonሀምስ.Text);
        }

        private void buttonሳድስ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonሳድስ.Text;
            wordadd(buttonሳድስ.Text);
        }

        private void buttonሳብዕ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonሳብዕ.Text;
            wordadd(buttonሳድስ.Text + "ኦ");
        }

        private void buttonዲቃላ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonዲቃላ.Text;
            wordadd(buttonሳድስ.Text + "ኧ");
        }

        private void buttonቈ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonቈ.Text;
        }

        private void buttonቊ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonቊ.Text;
        }

        private void buttonቋ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonቋ.Text;
        }

        private void buttonቌ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonቌ.Text;
        }

        private void buttonቍ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonቍ.Text;
        }

        private void buttonቘ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonቘ.Text;
        }

        private void buttonቚ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonቚ.Text;
        }

        private void buttonቛ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonቛ.Text;
        }

        private void buttonቜ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonቜ.Text;
        }

        private void buttonቝ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonቝ.Text;
        }

        private void buttonኊ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonኊ.Text;
        }

        private void buttonኋ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonኋ.Text;
        }

        private void buttonኌ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonኌ.Text;
        }

        private void buttonኍ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonኍ.Text;
        }

        private void buttonኰ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonኰ.Text;
        }

        private void buttonኲ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonኲ.Text;
        }

        private void buttonኳ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonኳ.Text;
        }

        private void buttonኴ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonኴ.Text;
        }

        private void buttonኵ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonኵ.Text;
        }

        private void buttonዀ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonዀ.Text;
        }

        private void buttonዂ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonዂ.Text;
        }

        private void buttonዃ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonዃ.Text;
        }

        private void buttonዄ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonዄ.Text;
        }

        private void buttonዅ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonዅ.Text;
        }

        private void buttonጐ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonጐ.Text;
        }

        private void buttonጒ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonጒ.Text;
        }

        private void buttonጓ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonጓ.Text;
        }

        private void buttonጔ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonጔ.Text;
        }

        private void buttonጕ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonጕ.Text;
        }

        private void buttonፘ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonፘ.Text;
        }

        private void buttonፙ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonፙ.Text;
        }

        private void buttonፚ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonፚ.Text;
        }

        private void buttonspace_Click(object sender, EventArgs e)
        {
            textBox1.Text += " ";
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {

        }

        void familyadd()
        {
            family fm;
            fm.ግዕዝ = buttonግዕዝ.Text;
            fm.ካብዕ = buttonካብዕ.Text;
            fm.ሳልስ = buttonሳልስ.Text;
            fm.ሪብዕ = buttonሪብዕ.Text;
            fm.ሀምስ = buttonሀምስ.Text;
            fm.ሳድስ = buttonሳድስ.Text;
            fm.ሳብዕ = buttonሳብዕ.Text;
            fm.ዲቃላ = buttonዲቃላ.Text;
        }

        void wordadd(string st )
        {
            word += st;
        }
        private void buttonstemmer_Click(object sender, EventArgs e)
        {
            //textBox2.Text = word;
            string[] words = word.Split(' ');
            for (int i=0; i<words.Count();i++)
            {
               char[] arr = words[i].ToCharArray();
               Affixes(arr);
            }
            textBox1.Clear();
        }

        void Affixes(char[] arr)
        { 
            //Suffix(arr);
            //Prefix(arr);
            //Infix(arr);
            //display(arr);
        }

        void Suffix(char[] arr)
        {
            char[] stemword;
            if (arr[arr.Length-1]== 'ት' && arr[arr.Length-2]== 'ነ')
            {
                stemword=new char[arr.Length-2];
                for(int i=0; i<arr.Length-2; i++)
                {
                    stemword[i]=arr[i];
                }
                display(stemword, arr.Length - 2); 
            }
            if (arr[arr.Length-1]== 'ች' && arr[arr.Length-2]== 'ኦ')
            {
                if ( arr[arr.Length - 3] == 'ው')
                {
                    stemword = new char[arr.Length - 3];
                    for (int i = 0; i < arr.Length - 3; i++)
                    {
                        stemword[i] = arr[i];
                    }
                    display(stemword, arr.Length - 3);
                }
                else
                {
                    stemword = new char[arr.Length - 2];
                    for (int i = 0; i < arr.Length - 2; i++)
                    {
                        stemword[i] = arr[i];
                    }
                    display(stemword, arr.Length - 2);
                }
            }
            if (arr[arr.Length - 1] == 'ኡ' || arr[arr.Length - 1] == 'ኧ')
            {
                stemword = new char[arr.Length - 1];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    stemword[i] = arr[i];
                }
                display(stemword, arr.Length - 1);
            }
            if (arr[arr.Length - 1] == 'ው' && arr[arr.Length - 2] == 'ቸ' && arr[arr.Length - 3] == 'ኣ')
            {
                stemword = new char[arr.Length - 3];
                for (int i = 0; i < arr.Length - 3; i++)
                {
                    stemword[i] = arr[i];
                }
                display(stemword, arr.Length - 3);
            }

        }

        void Prefix(char[] arr)
        {
            char[] stemword;
            if (arr[0] == 'ከ' || arr[0] == 'በ' || arr[0] == 'የ')
            {
                stemword = new char[arr.Length - 1];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    stemword[i] = arr[i+1];
                }
                display(stemword, arr.Length - 1);
            }
            if (arr[0] == 'ስ' && arr[1] == 'ለ')
            {
                stemword = new char[arr.Length - 2];
                for (int i = 0; i < arr.Length - 2; i++)
                {
                    stemword[i] = arr[i+2];
                }
                display(stemword, arr.Length - 2);
            }
            if (arr[0] == 'እ' && arr[1] == 'ን' && arr[2] == 'ደ')
            {
                stemword = new char[arr.Length - 3];
                for (int i = 0; i < arr.Length - 3; i++)
                {
                    stemword[i] = arr[i+3];
                }
                display(stemword, arr.Length - 3);
            }
        }

        void Infix(char[] arr)
        {
            char[] stemword;
            if (arr[1] == 'ና' || arr[1] == 'ባ' || arr[1] == 'ላ' || arr[1] == 'ጫ' || arr[1] == 'ጇ')
            {
                stemword = new char[arr.Length + 1];
                for (int i = 2; i < arr.Length + 1; i++)
                {
                    
                    stemword[i] = arr[i];
                    
                   // stemword[i] = arr[i];
                }
             
                display(stemword, arr.Length - 1);
            }
        }

        void display(char[] stemword,int arrlength)
        {
            for (int j = 0; j < arrlength; j++)
            {
                textBox2.Text += stemword[j].ToString();
            }
        }

    }
} 
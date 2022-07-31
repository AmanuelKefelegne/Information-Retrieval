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
        }

        public struct word
        {
            public string ግዕዝ;
            public string ካብዕ;
            public string ሳልስ;
            public string ሪብዕ;
            public string ሀምስ;
            public string ሳድስ;
            public string ሳብዕ;
            public string ዲቃላ;
        }

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
            wordadd(buttonግዕዝ.Text, "ግዕዝ");
        }

        private void buttonካብዕ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonካብዕ.Text;
            wordadd(buttonካብዕ.Text, "ካብዕ");
        }

        private void buttonሳልስ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonሳልስ.Text;
            wordadd(buttonሳልስ.Text, "ሳልስ");
        }

        private void buttonሪብዕ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonሪብዕ.Text;
            wordadd(buttonሪብዕ.Text, "ሪብዕ");
        }

        private void buttonሀምስ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonሀምስ.Text;
            wordadd(buttonሀምስ.Text, "ሀምስ");
        }

        private void buttonሳድስ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonሳድስ.Text;
            wordadd(buttonሳድስ.Text, "ሳድስ");
        }

        private void buttonሳብዕ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonሳብዕ.Text;
            wordadd(buttonሳብዕ.Text, "ሳብዕ");
        }

        private void buttonዲቃላ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonዲቃላ.Text;
            wordadd(buttonዲቃላ.Text, "ዲቃላ");
        }

        private void buttonቈ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonቈ.Text;
            wordadd(buttonቈ.Text, "ዲቃላ");
        }

        private void buttonቊ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonቊ.Text;
            wordadd(buttonቊ.Text, "ዲቃላ");
        }

        private void buttonቋ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonቋ.Text;
            wordadd(buttonቋ.Text, "ዲቃላ");
        }

        private void buttonቌ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonቌ.Text;
            wordadd(buttonቌ.Text, "ዲቃላ");
        }

        private void buttonቍ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonቍ.Text;
            wordadd(buttonቍ.Text, "ዲቃላ");
        }

        private void buttonቘ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonቘ.Text;
            wordadd(buttonቘ.Text, "ዲቃላ");
        }

        private void buttonቚ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonቚ.Text;
            wordadd(buttonቚ.Text, "ዲቃላ");
        }

        private void buttonቛ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonቛ.Text;
            wordadd(buttonቛ.Text, "ዲቃላ");
        }

        private void buttonቜ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonቜ.Text;
            wordadd(buttonቜ.Text, "ዲቃላ");
        }

        private void buttonቝ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonቝ.Text;
            wordadd(buttonቝ.Text, "ዲቃላ");
        }

        private void buttonኊ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonኊ.Text;
            wordadd(buttonኊ.Text, "ዲቃላ");
        }

        private void buttonኋ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonኋ.Text;
            wordadd(buttonኋ.Text, "ዲቃላ");
        }

        private void buttonኌ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonኌ.Text;
            wordadd(buttonኌ.Text, "ዲቃላ");
        }

        private void buttonኍ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonኍ.Text;
            wordadd(buttonኍ.Text, "ዲቃላ");
        }

        private void buttonኰ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonኰ.Text;
            wordadd(buttonኰ.Text, "ዲቃላ");
        }

        private void buttonኲ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonኲ.Text;
            wordadd(buttonኲ.Text, "ዲቃላ");
        }

        private void buttonኳ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonኳ.Text;
            wordadd(buttonኳ.Text, "ዲቃላ");
        }

        private void buttonኴ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonኴ.Text;
            wordadd(buttonኴ.Text, "ዲቃላ");
        }

        private void buttonኵ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonኵ.Text;
            wordadd(buttonኵ.Text, "ዲቃላ");
        }

        private void buttonዀ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonዀ.Text;
            wordadd(buttonዀ.Text, "ዲቃላ");
        }

        private void buttonዂ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonዂ.Text;
            wordadd(buttonዂ.Text, "ዲቃላ");
        }

        private void buttonዃ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonዃ.Text;
            wordadd(buttonዃ.Text, "ዲቃላ");
        }

        private void buttonዄ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonዄ.Text;
            wordadd(buttonዄ.Text, "ዲቃላ");
        }

        private void buttonዅ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonዅ.Text;
            wordadd(buttonዅ.Text, "ዲቃላ");
        }

        private void buttonጐ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonጐ.Text;
            wordadd(buttonጐ.Text, "ዲቃላ");
        }

        private void buttonጒ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonጒ.Text;
            wordadd(buttonጒ.Text, "ዲቃላ");
        }

        private void buttonጓ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonጓ.Text;
            wordadd(buttonጓ.Text, "ዲቃላ");
        }

        private void buttonጔ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonጔ.Text;
            wordadd(buttonጔ.Text, "ዲቃላ");
        }

        private void buttonጕ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonጕ.Text;
            wordadd(buttonጕ.Text, "ዲቃላ");
        }

        private void buttonፘ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonፘ.Text;
            wordadd(buttonፘ.Text, "ዲቃላ");
        }

        private void buttonፙ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonፙ.Text;
            wordadd(buttonፙ.Text, "ዲቃላ");
        }

        private void buttonፚ_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            textBox1.Text += buttonፚ.Text;
            wordadd(buttonፚ.Text, "ዲቃላ");
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
            //textBox2.Text = fm.ግዕዝ;
            //textBox2.Text += fm.ካብዕ;
            //textBox2.Text += fm.ሳልስ;
            //textBox2.Text += fm.ሪብዕ;
            //textBox2.Text += fm.ሀምስ;
            //textBox2.Text += fm.ሳድስ;
            //textBox2.Text += fm.ሳብዕ;
            //textBox2.Text += fm.ዲቃላ;

        }

        void wordadd(string st , string pos)
        {
            word wd;
            if(pos== "ግዕዝ")
            {
                wd.ግዕዝ = st;
            }
            if(pos== "ካብዕ")
            {
                wd.ካብዕ = st;
            }
            if (pos == "ሳልስ")
            {
                wd.ሳልስ = st;
            }
            if (pos == "ሪብዕ")
            {
                wd.ሪብዕ = st;
            }
            if (pos == "ሀምስ")
            {
                wd.ሀምስ = st;
            }
            if (pos == "ሳድስ")
            {
                wd.ሳድስ = st;
            }
            if (pos == "ሳብዕ")
            {
                wd.ሳብዕ = st;
            }
            if (pos == "ዲቃላ")
            {
                wd.ዲቃላ = st;
            }
        }

        private void buttonstemmer_Click(object sender, EventArgs e)
        {
            string[] words = textBox1.Text.Split(' ');
            for (int i=0; i<words.Count();i++)
            {

               char[] arr = words[i].ToCharArray();
                Affixes(arr);
            }
            textBox1.Clear();
        }

        void Affixes(char[] arr)
        { 
              Suffix(arr);
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
            if (arr[arr.Length-1]== 'ች' && arr[arr.Length-2]== 'ዎ')
            {
                stemword = new char[arr.Length - 2];
                for (int i = 0; i < arr.Length - 2; i++)
                {
                    stemword[i] = arr[i];
                }
                display(stemword, arr.Length - 2);
            }
            
        }

        void Prefix(char[] arr)
        {

        }

        void Infix(char[] arr)
        {

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
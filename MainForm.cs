using System.ComponentModel;

namespace VanityAddress
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        BindingList<Account> AccountList = new BindingList<Account>();
        Thread[] threads = new Thread[32];

        bool stop = true;
        string[] startsWith;
        string[] contains;
        string[] endsWith;
        bool requireAll;
        long count = 0;
        long lastCount = 0;

        public void ResizePanels()
        {
            pnlStartsWith.Height = pnlLeft.Height / 3;
            pnlContains.Height = pnlLeft.Height / 3;
            pnlEndsWith.Height = pnlLeft.Height / 3;
        }

        public void Run()
        {
            while (!stop)
            {
                Account account = NeoN3.GenerateAccount();
                count++;

                if (NeoN3.CheckAccount(account, startsWith, contains, endsWith, requireAll))
                {
                    AddToList(account);
                }
            }

            lastCount = 0;
        }

        public void AddToList(Account account)
        {   
            Invoke((ThreadStart)delegate () 
            {
                AccountList.Add(account);
                dgAccounts.CurrentCell = dgAccounts.Rows[AccountList.Count - 1].Cells[0];
            });
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            cmbThread.Enabled = !stop;
            txtStartsWith.Enabled = !stop;
            txtContains.Enabled = !stop;
            txtEndsWith.Enabled = !stop;
            btnClean.Enabled = !stop;
            chkRequireAll.Enabled = !stop;

            if (stop)
            {
                stop = false;
                count = 0;
                lastCount = 0;
                startsWith = txtStartsWith.Lines.Count() != 0 ? txtStartsWith.Lines : new string[0];
                contains = txtContains.Lines.Count() != 0 ? txtContains.Lines : new string[0];
                endsWith = txtEndsWith.Lines.Count() != 0 ? txtEndsWith.Lines : new string[0];
                requireAll = chkRequireAll.Checked;

                for (int i = 0; i < cmbThread.SelectedIndex + 1; i++)
                {
                    threads[i] = new Thread(Run);
                    threads[i].Start();
                }
            }
            else
            {
                stop = true;
            }

            btnStart.Text = stop ? "Start" : "Stop";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResizePanels();

            dgAccounts.DataSource = AccountList;

            for (int i = 0; i < Environment.ProcessorCount && i < 32; i++)
            {
                cmbThread.Items.Add((i + 1).ToString() + " Thread");
            }

            cmbThread.SelectedIndex = 0;
            timer1.Start();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            AccountList.Clear();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            stop = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            long setCount = count;
            lblInfo.Text = "Total Generated : " + setCount.ToString("N0") + "   |   Per Second : " + (setCount - lastCount) .ToString("N0")  + "   |   Found : " + AccountList.Count.ToString("N0");
            lastCount = setCount;
        }

        private void btnGitHub_Click(object sender, EventArgs e)
        {
            Utils.OpenWebPage("https://github.com/yildizoglu/NeoN3AddressGenerator");
        }

        private void btnTipBox_Click(object sender, EventArgs e)
        {
            Utils.OpenWebPage("https://dora.coz.io/address/neo3/mainnet/NeoN3cf9xDCrHwSgnjrHyojtZwZtqBqCrY");
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            ResizePanels();
        }
    }
}
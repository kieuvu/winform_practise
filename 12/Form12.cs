namespace WinFormsApp4
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(txt_n.Text);

            List<int> arr = findPrimes(n);

            txt_result.Text = string.Join(" ", arr);
        }

        private List<int> findPrimes(int N)
        {
            bool[] isPrime = new bool[N + 1];
            for (int i = 2; i <= N; i++)
            {
                isPrime[i] = true;
            }

            for (int p = 2; p * p <= N; p++)
            {
                if (isPrime[p] == true)
                {
                    for (int i = p * p; i <= N; i += p)
                    {
                        isPrime[i] = false;
                    }
                }
            }

            List<int> primes = new List<int>();
            for (int i = 2; i <= N; i++)
            {
                if (isPrime[i])
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
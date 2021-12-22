namespace VanityAddress
{
    public class Utils
    {
        public static void OpenWebPage(string url)
        {
            var uri = url;
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }
    }
}

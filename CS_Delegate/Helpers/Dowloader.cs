
public delegate void OnComplete();
public class Dowloader
{
    public void DowloadFile(string url, OnComplete callback)
    {
        Console.WriteLine($"Downloading from {url} ...");
        //Gia lap deplay
        Thread.Sleep(1000);
        Console.WriteLine("Download completed");
        callback?.Invoke();
    }
}
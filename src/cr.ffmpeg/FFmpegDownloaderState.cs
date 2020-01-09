namespace cr.ffmpeg
{
    public enum FFmpegDownloaderState
    {
        Ready,
        Downloading,
        Extracting,
        Done,
        Cancelled,
        Error
    }
}
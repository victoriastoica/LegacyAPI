namespace LegacyAPI.Model
{
    public class TaskSample
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; } = string.Empty;
        public DateTime TaskDate { get; set; }
        public string TaskType { get; set; } = string.Empty;
        public bool TaskIsProcessed { get; set; }
        public DateTime TaskModifyDate { get; set; }
        public string TaskModifyBy { get; set; } = string.Empty;
    }
}

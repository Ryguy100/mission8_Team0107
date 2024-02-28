namespace mission8_Team0107.Models
{
    public interface iTaskRepository
    {
        List<TaskEntity> Tasks { get; }

        public void AddTask(TaskEntity task);
    }
}

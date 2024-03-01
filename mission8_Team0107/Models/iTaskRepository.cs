namespace mission8_Team0107.Models
{
    public interface iTaskRepository
    {
        List<TaskEntity> Tasks { get; }
        List<Category> Categories { get; }

        public void AddTask(TaskEntity task);
        public void RemoveTask(TaskEntity task);
        public void UpdateTask(TaskEntity task);
    }
}

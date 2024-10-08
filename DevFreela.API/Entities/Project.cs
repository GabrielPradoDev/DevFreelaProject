using DevFreela.API.Enums;

namespace DevFreela.API.Entities
{
    public class Project : BaseEntity
    {
        protected Project() { }

        public Project(string title, string description, int idClient, int idFreelancer, decimal totalCost)
            :base()
        {
            Title = title;
            Description = description;
            IdClient = idClient;
            IdFreelancer = idFreelancer;
            TotalCost = totalCost;

            Status = ProjectsStatusEnum.Created;
            Comments = [];
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public int IdClient{ get; private set; }
        public User Client { get; private set; }
        public int IdFreelancer { get; private set; }
        public User Freelancer { get; private set; }
        public decimal TotalCost { get; private set; }
        public DateTime? StartedAt{ get; private set; }
        public DateTime? CompletedAt{ get; private set; }

        public ProjectsStatusEnum Status { get; private set; }
        public List<ProjectComment> Comments{ get; private set; }

        public void Cancel()
        {
            if (Status == ProjectsStatusEnum.InProgess || Status == ProjectsStatusEnum.Suspended)
            {
                Status = ProjectsStatusEnum.Cancelled;
            }
        }

        public void Start()
        {
            if (Status == ProjectsStatusEnum.Created)
            {
                Status = ProjectsStatusEnum.InProgess;
                StartedAt = DateTime.Now;
            }
        }

        public void Complete()
        {
            if (Status == ProjectsStatusEnum.PaymentPending || Status == ProjectsStatusEnum.InProgess)
            {
                Status = ProjectsStatusEnum.Completed;
                CompletedAt = DateTime.Now;
            }
        }

        public void SetPaymentPending()
        {
            if (Status == ProjectsStatusEnum.InProgess)
            {
                Status = ProjectsStatusEnum.PaymentPending;
            }
        }

        public void Update(string tiltle, string description, decimal totalCost)
        {
            Title = tiltle;
            Description = description;
            TotalCost = totalCost;
        }
    }

}

﻿using DevFreela.API.Enums;

namespace DevFreela.API.Entities
{
    public class Project : BaseEntity
    {
        public Project(string title, string description, int idClient, int idFreelancer, User freelancer, decimal totalCost)
        {
            Title = title;
            Description = description;
            IdClient = idClient;
            IdFreelancer = idFreelancer;
            Freelancer = freelancer;
            TotalCost = totalCost;
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
    }

}

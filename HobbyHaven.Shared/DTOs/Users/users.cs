﻿using HobbyHaven.Shared.DTOs.Hobbies;
using HobbyHaven.Shared.DTOs.PersonalityTag;
using HobbyHaven.Shared.DTOs.Havens;

namespace HobbyHaven.Shared.DTOs.Users
{
    public class DTOUser
    {
        public string UserID { get; set; } // Randomly generated unique identifier assigned to each user.
        public List<DTOPersonalityTag> PersonalityTags { get; set; } = new(); // Tags used to match the users personality/characteristics to a hobby.
        public List<DTOHobby> Hobbies { get; set; } = new(); // List of hobbies havens the user is enrolled in
    }

    public class DTOUserBasic
    {
        public string UserID { get; set; } // Randomly generated unique identifier assigned to each user.
        public List<Guid> PersonalityTags { get; set; } = new(); // Tags used to match the users personality/characteristics to a hobby.
        public List<Guid> Havens { get; set; } = new(); // List of hobbies havens the user is enrolled in
    }
}
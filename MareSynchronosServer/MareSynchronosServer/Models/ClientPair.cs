﻿using System.ComponentModel.DataAnnotations;

namespace MareSynchronosServer.Models
{
    public class ClientPair
    {
        [MaxLength(10)]
        public string UserUID { get; set; }
        public User User { get; set; }
        [MaxLength(10)]
        public string OtherUserUID { get; set; }
        public User OtherUser { get; set; }
        public bool IsPaused { get; set; }
        public bool AllowReceivingMessages { get; set; } = false;
        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}

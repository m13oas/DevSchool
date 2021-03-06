﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServerLogic.Map {
    public class Users {
        public Guid idUser                             { get; set; }
        public string email                            { get; set; }
        public string firstName                        { get; set; }
        public string lastName                         { get; set; }
        public string contactNumber                    { get; set; }
        public IEnumerable<Subscription> subscriptions { get; set; }
    }
}

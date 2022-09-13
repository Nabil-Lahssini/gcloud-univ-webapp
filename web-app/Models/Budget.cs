using System;
using Google.Cloud.Firestore;

namespace web_app.Models
{
    [FirestoreData]
    public class Budget
    {
            [FirestoreProperty]
            public string? Type { get; set; }

            [FirestoreProperty]
            public string? Product { get; set; }

            [FirestoreProperty]
            public int Price { get; set; }
        }
}



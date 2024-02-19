﻿using System;
using System.Collections.Generic;
using MyCourse.Models.Enums;
using MyCourse.Models.ValueObjects;

namespace MyCourse.Models.Entities
{
    public partial class Course
    {
        public Course(string title, string author)
        {

            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("The course must have a title");
            }
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("The course must have an author");
            }

            Title = title;
            Author = author;
            Lessons = new HashSet<Lesson>();
            CurrentPrice = new Money(Currency.EUR, 0);
            FullPrice= new Money(Currency.EUR, 0);
            ImagePath = "/Courses/default.png";
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string ImagePath { get; private set; }
        public string Author { get; private set; }
        public string Email { get; private set; }
        public double Rating { get; private set; }
        public Money FullPrice { get; private set; }
        public Money CurrentPrice { get; private set; }

        public void ChangeTitle(string newTitle)
        {
            
            if (string.IsNullOrWhiteSpace(newTitle))
            {
                throw new ArgumentException("The course must have a title");
            }

            Title = newTitle;
        }


        public void ChangePrices(Money newFullPrice, Money newCurrentPrice)
        {
            if (newFullPrice == null || newCurrentPrice == null)
            {
                throw new ArgumentException("Prices can't be null");
            }
            if (newFullPrice.Currency != newCurrentPrice.Currency)
            {
                throw new ArgumentException("Currencies don't match");
            }
            if (newFullPrice.Amount < newCurrentPrice.Amount)
            {
                throw new ArgumentException("Full price can't be less than the current price");
            }
            FullPrice = newFullPrice;
            CurrentPrice = newCurrentPrice;
        }

        public void ChangeEmail(string newEmail)
        {
            if (string.IsNullOrEmpty(newEmail))
            {
                throw new ArgumentException("Email can't be empty");
            }
            Email = newEmail;
        }

        public void ChangeDescription(string newDescription)
        {
            if (newDescription != null)
            {
                if (newDescription.Length < 20)
                {
                    throw new Exception("Description is too short");
                }
                else if (newDescription.Length > 4000)
                {
                    throw new Exception("Description is too long");
                }
            }
            Description = newDescription;
        }

        public virtual ICollection<Lesson> Lessons { get; private set; }
    }
}

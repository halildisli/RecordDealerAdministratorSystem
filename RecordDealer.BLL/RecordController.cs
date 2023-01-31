using RecordDealer.DAL.Entity;
using RecordDealer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RecordDealer.BLL
{
    public static class RecordController
    {
        private static RecordDealerEntities context = new RecordDealerEntities();
        public static Regex regex { get; set; }
        public static bool CheckLogin(string username, string password)
        {
            User foundedUser = context.Users.Where(x => x.Username == username).First();
            bool result;
            if (foundedUser != null)
            {
                password = PasswordHash(password);
                if (foundedUser.Password == password)
                {
                    result = true;

                }
                else
                {
                    result = false;
                }
            }
            else
            {
                result = false;
            }
            return result;
        }
        public static bool CheckPasswordRules(string password)
        {
            bool resultRules;
            regex = new Regex("^(?=.*[A-Z]{2,})(?=.*[!:+*]{2,})(?=.*[0-9])(?=.*[a-z]{3,})[A-Za-z!:+*0-9]{8,}$");
            if (regex.IsMatch(password))
            {
                resultRules = true;
            }
            else
            {
                resultRules = false;
            }
            return resultRules;
        }
        public static bool CheckSignUp(string username, string password)
        {
            bool result;
            if (context.Users.Where(x => x.Username == username).Count() == 0)
            {
                if (CheckPasswordRules(password))
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            else
            {
                result = false;
            }
            return result;
        }
        public static void AddAlbum(Album album)
        {
            if (context.Albums.Where(x => x.Name == album.Name).Count() == 0 && !string.IsNullOrEmpty(album.Name) && !string.IsNullOrEmpty(album.ArtistName) && album.Discontinued != null)
            {
                context.Albums.Attach(album);
                context.Entry(album).State = EntityState.Added;
            }
            context.SaveChanges();
        }
        public static void UpdateAlbum(List<Album> albums)
        {
            foreach (Album album in albums)
            {
                context.Albums.Attach(album);
                context.Entry(album).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
        public static void DeleteAlbum(List<Album> albums)
        {
            foreach (Album album in albums)
            {
                context.Albums.Remove(album);
            }
            context.SaveChanges();
        }
        public static void Refresh()
        {
            context.SaveChanges();
        }
        public static string PasswordHash(string password)
        {
            SHA256 hash = SHA256.Create();
            password = string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(c => c.ToString()));
            return password;
        }
    }
}

using SCD_LAB_W14.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCD_LAB_W14.Classes
{
    public class NewsSubject : INewsSubject
    {
        private List<INewsObserver> observers = new List<INewsObserver>();

        private static List<String> NewsTypes = new List<string> {"None","Politics", "Entertainment", "Sports"};

        private NewsDTO NDTO = new NewsDTO();

        private static List<NewsDTO> AllNews = new List<NewsDTO>();

        public NewsSubject()
        {
        }
        public NewsSubject(string newstype, string newsdetails)
        {
            NDTO.Newstype = newstype;
            NDTO.Newsdetails = newsdetails;
            AllNews.Add(NDTO);
        }

        public void addNews(string newstype, string newsdetails)
        {
            NDTO.Newsdetails = newsdetails;
            NDTO.Newstype = newstype;
            AllNews.Add(NDTO);
            //MessageBox.Show(newstype, newsdetails);
        }

        
        public List<NewsDTO> getAllNews()
        {
            return AllNews;
        }

        public void setNewsTypes(List<String> temp)
        {
            NewsTypes = temp;
        }
        public List<String> getNewsTypes()
        {
            return NewsTypes;
        }
        public void RegisterObserver(INewsObserver observer)
        {
            MessageBox.Show("Observer Added : " + ((Observer)observer).UserName);
            observers.Add(observer);
        }
        public void AddObservers(INewsObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(INewsObserver observer)
        {
            observers.Remove(observer);
        }
        public void NotifyObservers(string newstype)
        {
            foreach (INewsObserver observer in observers)
            {
                observer.update(newstype);
            }
        }
    }
}

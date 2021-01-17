using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CarouselBug
{
    public class MainPageViewModel : BaseViewModel
	{
        public MainPageViewModel()
        {
            
        }

        private ObservableCollection<CardsModel> _cards;
        public ObservableCollection<CardsModel> Cards
        {
            get { return _cards; }
            set
            {
                _cards = value;
                OnPropertyChanged(nameof(Cards));
            }
        }

        private ObservableCollection<CardsModel> _cards2;
        public ObservableCollection<CardsModel> Cards2
        {
            get { return _cards2; }
            set
            {
                _cards2 = value;
                OnPropertyChanged(nameof(Cards2));
            }
        }

        public void OnAppearing()
        {
            loadStaticData();
        }

        private void loadStaticData()
        {
            var cards = new ObservableCollection<CardsModel>();
            cards.Add(new CardsModel { ImageUrl = "https://pngimg.com/uploads/credit_card/credit_card_PNG95.png" });
            cards.Add(new CardsModel { ImageUrl = "https://pngimg.com/uploads/credit_card/credit_card_PNG71.png"});
            cards.Add(new CardsModel { ImageUrl = "https://pngimg.com/uploads/credit_card/credit_card_PNG99.png" });
            Cards = new ObservableCollection<CardsModel>(cards);

            var cards2 = new ObservableCollection<CardsModel>();
            cards2.Add(new CardsModel { ImageUrl = "https://pngimg.com/uploads/credit_card/credit_card_PNG84.png"});
            Cards2 = new ObservableCollection<CardsModel>(cards2);
        }
    }
}

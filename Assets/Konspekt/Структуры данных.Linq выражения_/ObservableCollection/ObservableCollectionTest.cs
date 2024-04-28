
using System.Collections.ObjectModel;
using UnityEngine;
using System.Collections.Specialized;
using System;

namespace ObservableCollectionTest
{
    public class ObservableCollectionTest : MonoBehaviour
    {
        private ObservableCollection<User> _users;

        private void Start()
        {
            _users = new ObservableCollection<User>
            {
                new User("Dmitry","Sergeev"),
                new User("Ivan","Lisenkov"),
                new User("Victoriya","Kurash")
            };

            _users.CollectionChanged += Users_CollectionChanged;

            _users.Add(new User("Lera", "Petrova"));
            _users.RemoveAt(1);
            _users[0] = new User("Sveta", "Ivanova");

            foreach (User user in _users)
            {
                Debug.Log(user.FirstName);
            }
        }

        private void Users_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    User newUser = (User)e.NewItems[0];
                    Debug.Log($"Добавлен новый элемент: {newUser.FirstName}");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    User oldUser = (User)e.OldItems[0];
                    Debug.Log($"Удален объект: {oldUser.FirstName}");
                    break;
                case NotifyCollectionChangedAction.Replace:
                    User replacedUser = (User)e.OldItems[0];
                    User replacingUser = (User)e.NewItems[0];
                    Debug.Log($"Объект {replacedUser.FirstName} заменен объектом {replacingUser.FirstName}");
                    break;
                case NotifyCollectionChangedAction.Move:
                    break;
                case NotifyCollectionChangedAction.Reset:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}

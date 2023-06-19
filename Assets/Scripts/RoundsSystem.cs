using UnityEngine;
using VContainer;
using VContainer.Unity;

internal class RoundsSystem : IInitializable
{
    private Timer _timer;

   // [SerializeField] private int _roundsCounter;

    public RoundsSystem(Dispatcher dispatcher)
    {
        Debug.Log("Rounds");
        Timer timer = new Timer(dispatcher, 5);
    }

    public void Initialize()
    {

    }

    /* IEnumerator RoundCounter()
     {
         while (true)
         {
             yield return new WaitForSeconds(_timer.RoundTime);
             _roundsCounter += 1;
             Debug.Log("Current round = " + _roundsCounter);
         }
     }
    */
}

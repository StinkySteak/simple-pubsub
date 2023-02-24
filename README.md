
# Simple PubSub

A small Unity Framework for Sending & Receiving Message through Signal without concrete implementation needed


## Usage/Examples

### Signal Structure
```csharp
public struct PlayerDamagedSignal : ISignal 
{
    public int ReduceAmount;
}
```

### Listener Implementation
```csharp
public class HealthHandler : MonoBehaviour 
{
    private void OnSignalReceived(PlayerDamagedSignal signal)
        => Debug.Log($"Reduce Amount: {signal.ReduceAmount}");
}
```

### Publisher Implementation
```csharp
public class PlayerHealth : MonoBehaviour 
{
    private void OnDamageReceived(int amount)
    {
        SignalManager.Publish(new PlayerDamagedSignal() 
        {
            ReduceAmount = amount
        });
    }
}
```

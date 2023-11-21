namespace Lab_04;

public abstract class Window
{
    #region Fields

    private static int _nextId;

    protected int _id;
    protected int _width;
    protected int _height;
    protected int _memoryNeeded;
    protected bool _areAdministatorRightsGranted;
    protected bool _isShown;

    #endregion


    public Window(int width, int height, bool areAdministatorRightsGranted)
    {
        _id = GetNextId();

        _width = width;
        _height = height;
        _areAdministatorRightsGranted = areAdministatorRightsGranted;
    }

    private static int GetNextId()
    {
        return _nextId++;
    }

    protected abstract void DoWork();

    public void ShowOrHide(bool isShown)
    {
        _isShown = isShown;
    }
}

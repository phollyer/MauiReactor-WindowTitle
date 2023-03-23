using MauiReactor;

namespace WindowTitle.Pages;

class MainPage : Component
{
    public override VisualNode Render()
    {
        return new NavigationPage
        {
            new ContentPage
            {
            }
        }
        .WindowTitle("My Window");
    }
}


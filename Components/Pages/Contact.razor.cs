using Microsoft.AspNetCore.Components;
using MrjSite.Model;
using MrjSite.Service;

namespace MrjSite.Components.Pages
{
    public partial class Contact
    {
        [SupplyParameterFromForm]
        private MessageViewModel? _message {  get; set; }
        [Inject] private AddMessageService service { get; set; } = default!;
        private bool _Submited;

        protected override void OnInitialized()
        {
            _message ??= new ();
            _Submited = false;
        }

        async Task SendMessage()
        {
            bool res = await service.AddMessage(_message);
            if (res)
            {
                _message = new();
                _Submited= true;
            }
            else
            {
                _Submited = false;
            }

        }
    }

   
}

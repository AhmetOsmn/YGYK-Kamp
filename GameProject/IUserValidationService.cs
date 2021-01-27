using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //Once interface ile baslamaliyiz.
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}

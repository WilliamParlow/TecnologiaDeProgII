Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "É Nóoois tamo junto"

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Contato é o caralho"

        Return View()
    End Function
End Class

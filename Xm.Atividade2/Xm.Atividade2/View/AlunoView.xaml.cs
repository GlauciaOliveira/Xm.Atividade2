using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xm.Atividade2.ViewModel;

namespace Xm.Atividade2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlunoView : ContentPage
    {
        AlunoViewModel vmAluno;

        public AlunoView()
        {
            //var aluno = AlunoViewModel.GetAluno(); vmAluno = new AlunoViewModel(aluno); BindingContext = vmAluno;

            InitializeComponent();
        }
    }
}
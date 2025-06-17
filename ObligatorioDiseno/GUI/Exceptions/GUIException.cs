using Dominio.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Exceptions
{
    public class GUIException : Exception
    {
        private GUIException(string message) : base(message)
        {
        }

        //used in ucpMovieSelector constructor
        public static GUIException nullProfileError()
        {
            return new GUIException("This profile does not exist.");
        }

        //used in ucpAddmovie.btnAddPoster_Click parse error message
        public static void posterImageError()
        {
            MessageBox.Show("This poster image is not valid, try another.");
        }

        //used in ucpEditMovie.btnSave_Click
        public static void movieEditedSuccessfully()
        {
            MessageBox.Show("Movie was successfully edited.");
        }

        //used in ucpEditMovie.btnRemove_Click
        public static void movieDeletedSuccessfully()
        {
            MessageBox.Show("Movie was successfully deleted.");
        }

        //used in ucpEditMovie.btnRemove_Click
        public static void movieDeletedError()
        {
            MessageBox.Show("No movie was deleted.");
        }

        //used in ucpEditMovie.btnEditRoles_Click
        public static void noMovieSelectedError()
        {
            MessageBox.Show("No movie is selected.");
        }

        //used in ucpChooseProfile.btnEnterPin_Click
        public static void incorrectPin()
        {
            MessageBox.Show("The written pin is incorrect.");
        }

        //used in ucpCreateOwnerProfile.btnCreateProfile_Click and ucpCreateProfile.button2_Click
        public static void pinFormatError()
        {
            MessageBox.Show("The pin cannot have letters or simbols.");
        }

        //used in ucpEditGenre.btnSave_Click
        public static void genreEditedSuccessfully()
        {
            MessageBox.Show("Genre was successfully edited.");
        }

        //used in ucpEditGenre.btnRemove_Click
        public static void genreDeletedSuccessfully()
        {
            MessageBox.Show("Genre was successfully deleted.");
        }

        //used in ucpEditGenre.btnRemove_Click
        public static void genreDeletedError()
        {
            MessageBox.Show("No genre was deleted.");
        }

        //used in ucpMovieSelector.dgvMovies_CellContentClick
        public static void registerViewError()
        {
            MessageBox.Show("Click on a movie name or poster to register a view.");
        }

        //used in ucpRegister.BtnRegister_Click
        public static void invalidEmail()
        {
            MessageBox.Show("The written email has not a valid format.");
        }

        //used in ucpRegister.BtnRegister_Click
        public static void noMatchingPassword()
        {
            MessageBox.Show("Passwords do not match.");
        }

        //used in ucpEditPerson.btnAddPhoto_Click and ucpEditPerson.cbPerson_SelectedIndexChanged
        public static void photoImageError()
        {
            MessageBox.Show("This poster image is not valid, try another.");
        }

        //used in ucpEditPerson.btnSave_Click
        public static void personEditedSuccessfully()
        {
            MessageBox.Show("Person was successfully edited.");
        }

        //used in ucpEditPerson.btnRemove_Click
        public static void personDeletedSuccessfully()
        {
            MessageBox.Show("Person was successfully deleted.");
        }

        //used in ucpEditPerson.btnRemove_Click
        public static void personDeletedError()
        {
            MessageBox.Show("No person was deleted.");
        }

        //used in ucpAddRole.btnAdd_Click
        public static void RoleAddSuccessfully()
        {
            MessageBox.Show("The role was added successfully.");
        }

        //used in ucpAddRole.btnCancel_Click
        public static void RoleAddError()
        {
            MessageBox.Show("No role was added.");
        }

        //used in ucpEditRoles.btnSave_Click
        public static void roleEditedSuccessfully()
        {
            MessageBox.Show("The role was modified successfully.");
        }

        //used in ucpEditRoles.btnSave_Click
        public static void roleEditError()
        {
            MessageBox.Show("No role was modified.");
        }

        //used in ucpEditRoles.btnRemove_Click
        public static void roleDeletedSuccessfully()
        {
            MessageBox.Show("The role was deleted successfully.");
        }

        //used in ucpEditRoles.btnRemove_Click
        public static void roleDeletedError()
        {
            MessageBox.Show("No role was deleted.");
        }

        //used in ucpEditMovie.btnEditRoles_Click
        public static void noSearchOptionError()
        {
            MessageBox.Show("Select an option to make a search.");
        }

        public static GUIException ImageLoadError()
        {
            return new GUIException("The image could not be loaded.");
        }

        public static GUIException YearParseError()
        {
            return new GUIException("The year must only have numbers.");
        }
    }
}

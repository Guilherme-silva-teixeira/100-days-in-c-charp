@page
@model application_01.Pages.Movies.DeleteModel

@{
 ViewData ["Título"] = "Excluir";
}

<h1>Delete</h1>

<h3>Are you sure you want to delete isto</h3>?
<div>
    <h4>Movie</h4>
    <hr />
    <dl classeeeeeeeeee="linha">
        <dt classeeeeeeeeee="col-sm-2">
            @Html. .DisplayNameFor (modelo => modelo.Movie.Title)
        </dt>
        <dd classeeeeeeeeee="col-sm-10">
            @Html. .DisplayFor (modelo => modelo.Movie.Title)
        </dd>
        <dt classeeeeeeeeee="col-sm-2">
            @Html. .DisplayNameFor (modelo => model.Movie.ReleaseDate)
        </dt>
        <dd classeeeeeeeeee="col-sm-10">
            @Html. .DisplayFor (modelo => modelo.Movie.ReleaseDate)
        </dd>
        <dt classeeeeeeeeee="col-sm-2">
            @Html. .DisplayNameFor (modelo => modelo.Movie.Genre)
        </dt>
        <dd classeeeeeeeeee="col-sm-10">
            @Html. .DisplayFor (modelo => modelo.Movie.Genre)
        </dd>
        <dt classeeeeeeeeee="col-sm-2">
            @Html. .DisplayNameFor (modelo => modelo.Movie.Price)
        </dt>
        <dd classeeeeeeeeee="col-sm-10">
            @Html. .DisplayFor (modelo => modelo.Movie.Price)
        </dd>
    </dl>
    
    <form method="post">
        <input type="oculto" asp-para="Movie.Id" />
        <input type="enviar" valor="Excluir" classeeeeeeeeee="btn btn-danger" /> |
        <a asp-page="./Índice"> Voltar à lista </a>
    </form>
</div>

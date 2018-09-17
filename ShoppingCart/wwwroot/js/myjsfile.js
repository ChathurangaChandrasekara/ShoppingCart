function fileupload(filename)
{
    var inputfile = document.getElementById(filename);
    var files = inputfile.ImageUrl;
    for (var i = 0; i != files.length; i++) {
        data.append("ImageUrl", files[i]);
    }

    $.ajax(
        {
            url:"/Shop",
            data: fdata,
            processData: false,
            contenType: false,
            type: "POST",
            success: function (data) {
                alert("file upload successfully");
            }
        }
    ) 
}
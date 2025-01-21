$(document).ready(function () {
    var editor = CKEDITOR.instances[''];
    if (editor) {
        editor.destroy(true);
    }
    CKEDITOR.replace('', {
        enterMode: CKEDITOR.ENTER_BR,
    })
})


function ContactSend()
{
    if ($("#name").val().trim() == "") {
        alert("�ж�g�m�W");
        return false;
    }
    if ($("#Phone").val().trim() == "") {
        if ($("#LocalPhone").val().trim() == "") {
            alert("�q�ܩΤ���п�ܤ@�˶�g");
            return false;
        }

    }

    $.ajax({
        url: "/Liu/InsertContact",
        type: "POST",
        data: $("#ContactForm").serialize(),
        success: function (data) {
            if (data.Status == "0") {
                alert("\n�T���G�e�X���\�A�ڭ̷|�ɧ��pô�z�I");

            } else {
                var message = data.StatusDesc;
                alert(message);
            }
        },
        error: function (err) {
            alert(err.Status);
        }
    });
}
async function confermMessage(title) {
    return await Swal.fire({
        title: title,
        confirmButtonText: "Yes",
        cancelButtonText: "No",
        showCancelButton: true,
    }).then((result) => {
        if (result.isConfirmed) {
            return "Yes";
        } else {
            return "No";
        }
    });
}
function applyFilter(value) {
    const currentUrl = new URL(window.location.href);
    currentUrl.searchParams.set("filter", value);
    window.location.href = currentUrl.toString();
}
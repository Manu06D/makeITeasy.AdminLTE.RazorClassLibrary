function setActiveMenuCurrentPage() {
    let activeNode =
        $("ul.nav-sidebar a.nav-link").filter(function (index) {
            return $(this).attr("href") != null && $(this).attr("href").toLowerCase() === window.location.pathname.toLowerCase();
        });
    activeNode.addClass("active");

    let parents = activeNode.parents("li.nav-item");
    parents.children("a.nav-link").addClass("active");
    parents.addClass("menu-is-opening menu-open");
}
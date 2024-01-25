<template>
    <div class="offcanvas offcanvas-end" tabindex="-1" id="navOffCanvas" aria-labelledby="navOffCanvasLabel">
        <div class="offcanvas-header">
            <h5 class="offcanvas-title fs-1" id="navOffCanvasLabel">Navigation</h5>
            <button type="button" class="btn-close" data-bs-dismiss="offcanvas" aria-label="Close"></button>
        </div>
        <div class="offcanvas-body">
            <nav class="text-secondary">
                <a href="#/" class="nav-link" @click="closeOffCanvas()">Home</a>
                <a href="#/larger-sculptures" class="nav-link" @click="closeOffCanvas()">Larger Sculptures</a>
                <a href="#/smaller-sculptures" class="nav-link" @click="closeOffCanvas()">Smaller Sculptures</a>
                <a href="#/about" class="nav-link" @click="closeOffCanvas()">About Me</a>
                <a href="#/artist-statement" class="nav-link" @click="closeOffCanvas()">Artist Statement</a>
            </nav>
        </div>
    </div>
</template>


<script>
import { Offcanvas } from 'bootstrap';

export default {
    setup() {
        function closeOffCanvas() {
            Offcanvas.getOrCreateInstance('#navOffCanvas').hide();
        }
        return { closeOffCanvas }
    }
};
</script>


<style lang="scss" scoped>
a {
    padding-bottom: .75em;
    padding-top: .75em;
    transition: ease-in-out .2s;
    font-size: 20pt;
}

a:not(:last-child) {
    border-bottom: solid 1px var(--bs-secondary);
}
</style>
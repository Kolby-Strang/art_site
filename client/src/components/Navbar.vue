<template>
  <div class="position-relative d-flex flex-column justify-content-center align-items-center px-3">
    <button class="btn nav-toggle d-block d-md-none" type="button" data-bs-toggle="offcanvas"
      data-bs-target="#navOffCanvas" aria-controls="navOffCanvas">
      <i class="fs-1 mdi mdi-menu"></i>
    </button>
    <img class="logo my-3" src="https://photos.strangkolby.com/art-site/Gia.jpg"
      alt="Photo of Gia">
    <div class="pt-3">
      <p class="fw-bold text-secondary fs-1 text-center mb-2">GIA FULLERTON STRANG</p>
    </div>
    <nav class="d-none d-md-flex text-secondary py-4">
      <a href="#/" class="nav-link">Home</a>
      <a href="#/sculptures" class="nav-link">Sculptures</a>
      <a href="#/about" class="nav-link">About Me</a>
      <a href="#/artist-statement" class="nav-link">Artist Statement</a>
      <a href="#/contact" class="nav-link">Contact Me</a>
    </nav>
  </div>
</template>

<script>
import { onMounted, ref } from 'vue';
import { loadState, saveState } from '../utils/Store.js';
import Login from './Login.vue';
export default {
  setup() {

    const theme = ref(loadState('theme') || 'light')

    onMounted(() => {
      document.documentElement.setAttribute('data-bs-theme', theme.value)
    })

    return {
      theme,
      toggleTheme() {
        theme.value = theme.value == 'light' ? 'dark' : 'light'
        document.documentElement.setAttribute('data-bs-theme', theme.value)
        saveState('theme', theme.value)
      }
    }
  },
  components: { Login }
}
</script>

<style scoped>
a {
  transition: ease-in-out .2s;
  padding-left: .8em;
  padding-right: .8em;
}

a:hover {
  font-size: 13pt;
}

a:not(:last-child) {
  border-right: solid 1px var(--bs-secondary);
}

.nav-link {
  text-transform: uppercase;
}

.nav-toggle {
  position: absolute;
  top: .5em;
  right: .2em;
}
</style>

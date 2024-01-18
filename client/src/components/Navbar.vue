<template>
  <div class="d-flex flex-column justify-content-center align-items-center px-3">
    <img class="logo"
      src="https://images.squarespace-cdn.com/content/v1/5966dcbd6a49633636c3a928/58eef998-fc47-4dc7-955b-06f9b4e5d840/Green+Modern+Fashion+Store+Logo.png"
      alt="logo">
    <router-link class="fs-1" :to="{ name: 'Home' }">
      <p class="fw-bold nav-link">Gia Fullerton Strang</p>
    </router-link>
    <nav class="d-flex">
      <a href="#/larger-sculptures" class="nav-link">Larger Sculptures</a>
      <a href="#/smaller-sculptures" class="nav-link">Smaller Sculptures</a>
      <a href="#/about" class="nav-link">About Me</a>
      <a href="#/artist-statement" class="nav-link">Artist Statement</a>
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
  text-decoration: none;
}

.nav-link {
  text-transform: uppercase;
}

.navbar-nav .router-link-exact-active {
  border-bottom: 2px solid var(--bs-success);
  border-bottom-left-radius: 0;
  border-bottom-right-radius: 0;
}

@media screen and (min-width: 768px) {
  nav {
    height: 64px;
  }
}
</style>

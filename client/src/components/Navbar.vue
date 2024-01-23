<template>
  <div class="d-flex flex-column justify-content-center align-items-center px-3">
    <img class="logo my-3" src="https://yzcvxjdmcmvriilyesrf.supabase.co/storage/v1/object/public/images/Gia"
      alt="Photo of Gia">
    <div class="py-3">
      <p class="fw-bold text-secondary fs-1">GIA FULLERTON STRANG</p>
    </div>
    <nav class="d-flex text-secondary">
      <a href="#/" class="nav-link">Home</a>
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
  height: max-content;
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

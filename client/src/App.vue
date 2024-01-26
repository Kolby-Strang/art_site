<template>
  <header>
    <Navbar />
  </header>
  <main>
    <router-view />
  </main>
  <footer class="bg-primary">
    <FooterComponent />
  </footer>
  <NavOffCanvas />
</template>

<script>
import { computed } from 'vue'
import { AppState } from './AppState'
import Navbar from './components/Navbar.vue'
import FooterComponent from './components/FooterComponent.vue'
import NavOffCanvas from './components/NavOffCanvas.vue'

export default {
  setup() {
    return {
      appState: computed(() => AppState)
    }
  },
  components: { Navbar, NavOffCanvas, FooterComponent }
}
</script>
<style lang="scss">
@import "./assets/scss/main.scss";

:root {
  --main-height: calc(100vh - 32px - 64px);
}
</style>

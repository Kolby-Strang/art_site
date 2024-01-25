<template>
  <header>
    <Navbar />
  </header>
  <main>
    <router-view />
  </main>
  <NavOffCanvas />
</template>

<script>
import { computed } from 'vue'
import { AppState } from './AppState'
import Navbar from './components/Navbar.vue'
import NavOffCanvas from './components/NavOffCanvas.vue'

export default {
  setup() {
    return {
      appState: computed(() => AppState)
    }
  },
  components: { Navbar, NavOffCanvas }
}
</script>
<style lang="scss">
@import "./assets/scss/main.scss";

:root {
  --main-height: calc(100vh - 32px - 64px);
}
</style>

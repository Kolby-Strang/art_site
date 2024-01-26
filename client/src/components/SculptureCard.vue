<template>
    <div class="container-fluid border-secondary px-0">
        <router-link :to="`sculpture/${sculpture.id}`" class="fw-bold text-shadow text-white">
            <img class="aspect-1-1 img-fluid fit-cover rounded" :src="sculpture.coverImg" alt="">
            <p class="cover-title mb-0 fs-4">{{ sculpture.name }}</p>
            <p class="cover-year mb-0">{{ sculpture.year }}</p>
        </router-link>
    </div>
</template>


<script>
import { Sculpture } from '../models/Sculpture';

export default {
    props: {
        sculpture: { type: Sculpture, required: true }
    },
    setup() {
        return {}
    }
};
</script>


<style lang="scss" scoped>
.container-fluid {
    border-radius: 6px;
    border: solid .5px;
    position: relative;
}

.cover-title {
    position: absolute;
    bottom: .5rem;
    left: .5rem;
    max-width: 70%;
}

.cover-year {
    position: absolute;
    bottom: .5rem;
    right: .5rem;
}
</style>
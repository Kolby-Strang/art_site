<template>
    <div class="container-fluid">
        <div class="row px-0">
            <div class="col-12 bg-moon-gate text-center py-5">
                <p class="fs-0 text-shadow text-white fw-bold my-5 py-5">My Sculptures</p>
            </div>
        </div>
        <div v-if="sculptures.length > 0" class="row px-1">
            <div v-for="sculpture in sculptures" class="col-12 col-sm-6 col-md-4 col-lg-3 col-xxl-2 p-4">
                <SculptureCard :sculpture="sculpture" />
            </div>
        </div>
        <Loader v-else />
    </div>
</template>


<script>
import { onMounted, ref } from 'vue';
import Pop from '../utils/Pop';
import { sculpturesService } from '../services/SculpturesService';
import SculptureCard from '../components/SculptureCard.vue'
import Loader from '../components/Loader.vue'

export default {
    setup() {
        // VARIABLES
        const sculptures = ref([])
        // FUNCTIONS
        async function getAllSculptures() {
            try {
                sculptures.value = await sculpturesService.getAllSculptures()
            } catch (err) {
                Pop.error(err)
            }
        }
        // LIFECYCLE
        onMounted(() => {
            getAllSculptures()
        })
        return { sculptures }
    },
    components: { SculptureCard, Loader }
};
</script>


<style lang="scss" scoped>
.bg-moon-gate {
    background-image: url(https://photos.strangkolby.com/art-site/zmoongate/0.jpeg);
    background-position: center;
    background-size: cover;
}
</style>
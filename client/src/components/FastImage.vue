<template>
    <img :id="_id + 'L'" :src="_src + 'l'" :class="_class" :alt="_alt">
    <img :id="_id" @load="upgradeImage" :src="_src" :alt="_alt" class="hidden" :class="_class">
</template>


<script>
import { onMounted } from 'vue';


export default {
    props: {
        _id: { default: () => Math.floor(Math.random() * 10000) + '-' + Math.floor(Math.random() * 10000) },
        _src: { type: String, required: true },
        _alt: { type: String, required: true },
        _class: { type: String, required: false }
    },
    setup(props) {
        const id = props._id
        const idL = id + 'L'
        function upgradeImage() {
            const elemH = document.getElementById(id)
            const elemL = document.getElementById(idL)
            elemH.classList.remove('hidden')
            elemL.classList.add('hidden')
        }
        return {
            upgradeImage
        }
    }
};
</script>


<style lang="scss" scoped></style>
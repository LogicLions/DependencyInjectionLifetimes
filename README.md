// refresh the Index page to check the difference
// for every refresh ...
// Transient : 2 objects will generate new guids everytime seperately. means 1st object is not shared with 2nd request. it creates new object.
// Scoped : 2 objects will generate same guids. guid changes only when page refreshed. but same for both objects. means 1st object is shared for 2nd request.
// Singleton : 2 objects will generate same guids. same guids even if page refreshed. means one single object is shared for entire application lifetime.
